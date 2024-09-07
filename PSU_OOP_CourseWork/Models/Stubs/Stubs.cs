using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using DynamicData;
using DynamicData.Kernel;
using PSU_OOP_CourseWork.Models.Datums;
using PSU_OOP_CourseWork.Util;

namespace PSU_OOP_CourseWork.Models.Stubs;

/// <summary>
/// Фейковый класс для всевдоработы с БД во время отладки других систем
/// </summary>
public partial class Stubs : IMenu, IOrders
{
    ReadOnlyObservableCollection<Dish> IMenu.Items => _Dishes ??= dishes.TransformedToReadonly();
    ReadOnlyObservableCollection<Order> IOrders.Items => _Orders ??= orders.TransformedToReadonly();

    // Alias for private usage
    // ReSharper disable InconsistentNaming
    private ReadOnlyObservableCollection<Dish>? _Dishes;
    private ReadOnlyObservableCollection<Order>? _Orders;
    // ReSharper restore InconsistentNaming

    private int NextDishId => dishes.Select(order => order.Id).Max() + 1;

    void IOrders.Push(IEnumerable<OrderPosition> positions)
    {
        orders.Add(new Order(
            NextDishId,
            [..positions],
            PriceOf(positions),
            DateTime.Now
        ));
    }

    void IMenu.ChangePrice(int id, decimal priceRoubles)
    {
        var toChange = dishes.First(dish => dish.Id == id);

        dishes.Replace(toChange, toChange with {PriceRoubles = priceRoubles});
    }

    void IMenu.Remove(int id)
    {
        if (orders.Any(order => order.Dishes.Any(position => position.DishId == id)))
        {
            throw new ConstraintException();
        }

        var toRemove = dishes.FirstOrOptional(dish => dish.Id == id);
        if (toRemove.HasValue)
        {
            dishes.Remove(toRemove.Value);
        }
    }

    void IOrders.Remove(int id)
    {
        var toRemove = orders.FirstOrOptional(order => order.Id == id);
        if (toRemove.HasValue)
        {
            orders.Remove(toRemove.Value);
        }
    }

    private decimal PriceOf(IEnumerable<OrderPosition> positions)
        => positions.Sum(op => dishes.First(dish => dish.Id == op.DishId).PriceRoubles * op.Quantity);
}