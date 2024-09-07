using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Globalization;
using System.IO;
using System.Linq;
using PSU_OOP_CourseWork.Models.Datums;
using PSU_OOP_CourseWork.Util;

namespace PSU_OOP_CourseWork.DB;

public partial class SqlService
{
    /// <summary>
    /// Выгружает данные БД в текстовом, ~читабельном формате
    /// <exception cref="ArgumentException">Выбрасывается, если путь плохой</exception>
    /// </summary>
    public void Save()
    {
        var dishesAndOrders = dishes
            .Select(x => x.ToString())
            .Append("") // Separator empty line
            .AppendAll
            (
                orders.SelectMany
                (order =>
                    order.Dishes.Select
                    (position =>
                        position.ToString().Replace(nameof(OrderPosition), $"{nameof(OrderPosition)}#{order.Id}")
                    )
                )
            )
            .Append("")
            .AppendAll(orders.Select(x => x.ToString()))
            .ToArray();

        if (!Directory.Exists(OutputsDir))
        {
            Directory.CreateDirectory(OutputsDir);
        }
        if (File.Exists(SavePath))
        {
            File.Delete(SavePath);
        }
        File.WriteAllLines(SavePath, dishesAndOrders);
    }

    /// <summary>
    /// Загружает данные БД из ранее выгруженного формата
    /// </summary>
    public void Load()
    {
        if (!File.Exists(SavePath))
        {
            return;
        }

        var positions = new Dictionary<int, List<OrderPosition>>();
        var lines = File.ReadLines(SavePath).Select(LineData.ParseOrNull).WhereNotNull();

        Create();
        dishes.Clear();
        orders.Clear();
        foreach (var (type, mess, i) in lines)
        {
            switch (type)
            {
                case nameof(Dish):
                    dishes.Add(ParseDish(mess));
                    break;

                case nameof(OrderPosition):
                    var orderI = i!.Value;
                    if (!positions.TryGetValue(orderI, out var value))
                    {
                        value = [];
                        positions[orderI] = value;
                    }
                    value.Add(ParseOrderPosition(mess));
                    break;

                case nameof(Order):
                    orders.Add(ParseOrder(mess));
                    break;
            }
        }

        RewriteAndReselect();
        return;

        Dish ParseDish(string mess)
        {
            var fields = mess.Split([", ", "{ ", " }"], StringSplitOptions.RemoveEmptyEntries);

            var id = int.Parse(fields[0].Split(" = ")[1]);
            var name = fields[1].Split(" = ")[1];
            var description = fields[2].Split(" = ")[1];
            var priceRoubles = decimal.Parse(fields[3].Split(" = ")[1]);

            return new(id, name, description, priceRoubles);
        }

        Order ParseOrder(string mess)
        {
            var fields = mess.Split([", ", "{ ", " }"], StringSplitOptions.RemoveEmptyEntries);

            var id = int.Parse(fields[0].Split(" = ")[1]);
            var orderDishes = positions.GetValueOrDefault(id, []).ToImmutableArray();
            var costRoubles = decimal.Parse(fields[2].Split(" = ")[1]);
            var dateTime = DateTime.ParseExact(fields[3].Split(" = ")[1], "dd.MM.yyyy HH:mm:ss", new CultureInfo("en-UK"));

            return new(id, orderDishes, costRoubles, dateTime);
        }

        OrderPosition ParseOrderPosition(string mess)
        {
            var fields = mess.Split([", ", "{ ", " }"], StringSplitOptions.RemoveEmptyEntries);

            var dishId = int.Parse(fields[0].Split(" = ")[1]);
            var quantity = int.Parse(fields[1].Split(" = ")[1]);

            return new(dishId, quantity);
        }
    }

    private record struct LineData(string Type, string Mess, int? I = null)
    {
        public static LineData? ParseOrNull(string line)
        {
            var parts = line.Split(' ', 2);
            if (parts.Length != 2)
            {
                return null;
            }

            return parts[0].Contains('#') ?
                ParseWithI(parts[0], parts[1]) :
                new LineData(parts[0], parts[1]);

            static LineData ParseWithI(string head, string mess)
            {
                var parts = head.Split('#');
                return new LineData(parts[0], mess, int.Parse(parts[1]));
            }
        }
    }
}