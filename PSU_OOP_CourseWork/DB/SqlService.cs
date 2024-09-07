using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using PSU_OOP_CourseWork.Models.Datums;
using PSU_OOP_CourseWork.Util;

namespace PSU_OOP_CourseWork.DB;

/// <summary>
/// Фасад работы с БД на SQL
/// </summary>
public partial class SqlService
{
    private const string OutputsDir = "./outputs";
    private const string SavePath = $"{OutputsDir}/save.txt";
    private const string DbPath = $"{OutputsDir}/data.db";

    /// <summary>
    /// Источник текущих данных о хранимых блюдах
    /// </summary>
    public ReadOnlyObservableCollection<Dish> Dishes { get; }

    /// <summary>
    /// Источник текущих данных о хранимых заказах
    /// </summary>
    public ReadOnlyObservableCollection<Order> Orders { get; }

    private readonly ObservableCollection<Dish> dishes = new([]);
    private readonly ObservableCollection<Order> orders = new([]);

    /// <summary>
    /// Инициализирует публичные источники данных и первчино создаёт или закгружает БД
    /// </summary>
    public SqlService()
    {
        Dishes = dishes.TransformedToReadonly();
        Orders = orders.TransformedToReadonly();

        LoadOrCreate();
    }

    /// <summary>
    /// Добавляет новый заказ в БД и перезагружает источник заказов 
    /// </summary>
    /// <param name="positions">Позиции заказа</param>
    public void PushOrder(IEnumerable<OrderPosition> positions)
    {
        InitOrder(out var orderId);
        InsertOrderPositions(orderId, positions);
        DeriveOrdersCost(orderId);
        ReselectOrders();
    }

    /// <summary>
    /// Меняет цену блюда
    /// </summary>
    /// <param name="id">Id блюда</param>
    /// <param name="priceRoubles">Новая цена блюда</param>
    public void ChangeDishPrice(int id, decimal priceRoubles)
    {
        UpdateDishPrice(id, priceRoubles);
        ReselectDishes();
    }

    /// <summary>
    /// Удаляет блюдо из меню по его Id, если оно не упомянуто в заказах
    /// </summary>
    /// <param name="id">Id блюда</param>
    /// <exception cref="ConstraintException">Исключение бросается6 если блюдо нельзя удалить в связи с его использованием в заказах</exception>
    public void RemoveDish(int id)
    {
        if (IsDishIdReferencedInOrders(id))
        {
            throw new ConstraintException();
        }

        DeleteDish(id);
        ReselectDishes();
    }

    /// <summary>
    /// Удаление заказа
    /// </summary>
    /// <param name="id">Id удаляемого заказа</param>
    public void RemoveOrder(int id)
    {
        DeleteOrder(id);
        ReselectOrders();
    }
}