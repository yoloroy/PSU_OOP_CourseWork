using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using DynamicData;
using Microsoft.Data.Sqlite;
using PSU_OOP_CourseWork.Models.Datums;
using PSU_OOP_CourseWork.Util;

namespace PSU_OOP_CourseWork.DB;

public partial class SqlService
{
    private readonly string connectionString = new SqliteConnectionStringBuilder()
    {
        Mode = SqliteOpenMode.ReadWriteCreate,
        DataSource = DbPath
    }.ToString();

    private DbConnection NewConnection() => new SqliteConnection(connectionString);

    private void Create()
    {
        using var connection = NewConnection();
        using var command = connection.CreateCommand();
        command.CommandText =
        """
        DROP TABLE IF EXISTS dishes;
        DROP TABLE IF EXISTS orders;
        DROP TABLE IF EXISTS order_positions;
        DROP TABLE IF EXISTS orders_cost;
        CREATE TABLE dishes(
            id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
            name TEXT NOT NULL,
            description TEXT,
            price_roubles DECIMAL(9, 2) NOT NULL
        );
        CREATE TABLE orders(
            id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
            date_time DATETIME NOT NULL
        );
        CREATE TABLE order_positions(
            order_id INTEGER NOT NULL,
            dish_id INTEGER NOT NULL,
            quantity INTEGER NOT NULL
        );
        CREATE TABLE orders_cost(
            order_id INTEGER PRIMARY KEY NOT NULL,
            cost_roubles DECIMAL(11, 2) NOT NULL
        );
        """;
        connection.Open();
        command.ExecuteNonQuery();
        connection.Close();
    }

    private void LoadOrCreate()
    {
        if (!IsAllTablesInitialized())
        {
            Create();
        }

        Reselect();
        return;

        bool IsAllTablesInitialized()
        {
            Dictionary<string, bool> tablesToBe = new ()
            {
                ["dishes"] = false,
                ["orders"] = false,
                ["order_positions"] = false,
                ["orders_cost"] = false
            };

            using var connection = NewConnection();
            using var command = connection.CreateCommand();
            command.CommandText = "SELECT name FROM sqlite_master WHERE type = 'table'";

            connection.Open();
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                tablesToBe[reader.GetString(0)] = true;
            }
            connection.Close();
            return tablesToBe.All(kv => kv.Value);
        }
    }

    private void Reselect()
    {
        ReselectDishes();
        ReselectOrders();
    }

    private void ReselectOrders()
    {
        var positions = RetrievePositions();

        using var connection = NewConnection();
        using var command = connection.CreateCommand();
        command.CommandText =
        """
        SELECT orders.id, orders.date_time, orders_cost.cost_roubles
        FROM orders
        JOIN orders_cost ON orders_cost.order_id = orders.id
        """;

        connection.Open();
        using var reader = command.ExecuteReader();
        var buffer = new List<Order>();
        while (reader.Read())
        {
            var id = reader.GetInt32(0);
            buffer.Add
            (new(
                id,
                [..positions.GetValueOrDefault(id, [])],
                reader.GetDecimal(2),
                reader.GetDateTime(1)
            ));
        }
        connection.Close();
        orders.Clear();
        orders.AddRange(buffer);
    }

    private void ReselectDishes()
    {
        using var connection = NewConnection();
        using var command = connection.CreateCommand();
        command.CommandText = "SELECT dishes.id, dishes.name, dishes.description, dishes.price_roubles FROM dishes";

        connection.Open();
        using var reader = command.ExecuteReader();
        var buffer = new List<Dish>();
        while (reader.Read())
        {
            buffer.Add(new(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDecimal(3)));
        }
        connection.Close();
        dishes.Clear();
        dishes.AddRange(buffer);
    }

    private void RewriteAndReselect()
    {
        #region clearing
        {
            using var connection = NewConnection();
            using var command = connection.CreateCommand();
            connection.Open();
            command.CommandText =
            """
            DELETE FROM dishes;
            DELETE FROM orders;
            DELETE FROM order_positions;
            DELETE FROM orders_cost
            """;
            command.ExecuteNonQuery();
            connection.Close();
        }
        #endregion

        #region insertion
        foreach (var (_, name, description, priceRoubles) in dishes)
        {
            InsertDish(name, priceRoubles, description);
        }
        foreach (var (_, orderPositions, costRoubles, dateTime) in orders)
        {
            InsertOrder(out var orderId, dateTime);
            InsertOrderPositions(orderId, orderPositions);
            InsertOrderCost(orderId, costRoubles);
        }
        #endregion

        Reselect();
    }

    private Dictionary<int, List<OrderPosition>> RetrievePositions()
    {
        Dictionary<int, List<OrderPosition>> positions = new();
        using var connection = NewConnection();
        using var command = connection.CreateCommand();
        command.CommandText = "SELECT order_id, dish_id, quantity from order_positions";

        connection.Open();
        using var reader = command.ExecuteReader();
        while (reader.Read())
        {
            var orderId = reader.GetInt32(0);
            OrderPosition position = new(reader.GetInt32(1), reader.GetInt32(2));
            if (positions.TryGetValue(orderId, out List<OrderPosition>? value))
            {
                value.Add(position);
            }
            else
            {
                positions[orderId] = [position];
            }
        }
        connection.Close();

        return positions;
    }

    private void InitOrder(out int orderId)
    {
        using var connection = NewConnection();
        using var command = connection.CreateCommand();
        command.CommandText = "INSERT INTO orders(date_time) VALUES (DATETIME('now'));";
        connection.Open();
        command.ExecuteNonQuery();
        command.CommandText = "SELECT last_insert_rowid();";
        orderId = (int) (long) command.ExecuteScalar()!;
        connection.Close();
    }

    private void InsertOrder(out int orderId, DateTime dateTime)
    {
        using var connection = NewConnection();
        using var command = connection.CreateCommand();
        command.CommandText = $"INSERT INTO orders(date_time) VALUES (DATETIME(\"{dateTime:yyyy-MM-dd HH:mm:ss}\")); SELECT last_insert_rowid();";
        connection.Open();
        orderId = (int) (long) command.ExecuteScalar()!;
        connection.Close();
    }
    
    private void DeriveOrdersCost(int orderId)
    {
        var connection = NewConnection();
        using var command = connection.CreateCommand();
        command.CommandText =
        $"""
        INSERT INTO orders_cost(order_id, cost_roubles)
        SELECT
            order_positions.order_id AS order_id,
            COALESCE(SUM(dishes.price_roubles * order_positions.quantity), 0) AS cost_roubles
        FROM order_positions
        LEFT JOIN dishes ON dishes.id = order_positions.dish_id
        WHERE order_positions.order_id = {orderId};--
        """;
        connection.Open();
        command.ExecuteNonQuery();
        connection.Close();
    }

    private void InsertOrderCost(int orderId, decimal costRoubles)
    {
        var connection = NewConnection();
        using var command = connection.CreateCommand();
        command.CommandText = $"INSERT INTO orders_cost(order_id, cost_roubles) VALUES ({orderId}, {costRoubles});";
        connection.Open();
        command.ExecuteNonQuery();
        connection.Close();
    }

    private void InsertOrderPositions(int orderId, IEnumerable<OrderPosition> positions)
    {
        var connection = NewConnection();
        using var command = connection.CreateCommand();
        command.CommandText = "INSERT INTO order_positions(order_id, dish_id, quantity) VALUES (@order_id, @dish_id, @quantity)";

        #region parameters
        var orderIdParameter = command.CreateParameter();
        command.Parameters.Add(orderIdParameter);
        orderIdParameter.DbType = DbType.Int32;
        orderIdParameter.ParameterName = "@order_id";
        orderIdParameter.Value = orderId;

        var dishIdParameter = command.CreateParameter();
        command.Parameters.Add(dishIdParameter);
        dishIdParameter.DbType = DbType.Int32;
        dishIdParameter.ParameterName = "@dish_id";
        var quantityParameter = command.CreateParameter();
        command.Parameters.Add(quantityParameter);
        quantityParameter.DbType = DbType.Int32;
        quantityParameter.ParameterName = "@quantity";
        #endregion

        connection.Open();
        foreach (var (dishId, quantity) in positions)
        {
            dishIdParameter.Value = dishId;
            quantityParameter.Value = quantity;
            command.ExecuteNonQuery();
        }
        connection.Close();
    }

    private void InsertDish(string name, decimal priceRoubles, string? description = null)
    {
        using var connection = NewConnection();
        using var command = connection.CreateCommand();
        command.CommandText =
        $@"
            INSERT INTO dishes(name, description, price_roubles)
            VALUES (""{name}"", ""{description.CoalesceEmpty()}"", {priceRoubles});
        ";
        connection.Open();
        command.ExecuteNonQuery();
        connection.Close();
    }

    private void UpdateDishPrice(int id, decimal priceRoubles)
    {
        using var connection = NewConnection();
        using var command = connection.CreateCommand();
        command.CommandText = $"UPDATE dishes SET price_roubles = {(float) priceRoubles} WHERE id = {id};";
        connection.Open();
        command.ExecuteNonQuery();
        connection.Close();
    }

    private bool IsDishIdReferencedInOrders(int id)
    {
        using var connection = NewConnection();
        using var command = connection.CreateCommand();
        command.CommandText = $"SELECT COUNT(*) FROM order_positions WHERE dish_id = {id};";
        connection.Open();
        var isReferenced = (long) command.ExecuteScalar()! > 0;
        connection.Close();
        return isReferenced;
    }

    private void DeleteDish(int id)
    {
        using var connection = NewConnection();
        using var command = connection.CreateCommand();
        command.CommandText = $"DELETE FROM dishes WHERE id = {id};";
        connection.Open();
        command.ExecuteNonQuery();
        connection.Close();
    }

    private void DeleteOrder(int id)
    {
        using var connection = NewConnection();
        using var command = connection.CreateCommand();
        connection.Open();
        command.CommandText =
        $"""
        DELETE FROM order_positions WHERE order_id = {id};
        DELETE FROM orders_cost WHERE order_id = {id};
        DELETE FROM orders WHERE id = {id};--
        """;
        command.ExecuteNonQuery();
        connection.Close();
    }
}