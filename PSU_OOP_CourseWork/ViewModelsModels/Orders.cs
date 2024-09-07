using System;
using System.Collections.ObjectModel;
using System.Linq;
using PSU_OOP_CourseWork.Models.Datums;
using PSU_OOP_CourseWork.Util;
using VM = PSU_OOP_CourseWork.ViewModels.Source;
using M = PSU_OOP_CourseWork.Models;

namespace PSU_OOP_CourseWork.ViewModelsModels;

/// <summary>
/// Адаптер заказов из модельного слоя во viewmodel'ный
/// </summary>
/// <param name="orders"></param>
/// <param name="menu"></param>
public class Orders(M.IOrders orders, M.IMenu menu) : VM.IOrders
{
    /// <summary>
    /// Ресформированные заказы 
    /// </summary>
    public ReadOnlyObservableCollection<VM.Order> Data { get; } = orders.Items.Transformed
    (
        order =>
        new VM.Order
        (
            order.Id,
            string.Join(", ", order.Dishes.Select(DescriptionSelector(menu))),
            order.CostRoubles,
            order.DateTime
        )
    );

    private static Func<OrderPosition, string> DescriptionSelector(M.IMenu menu)
    {
        return position => $"\"{menu.Items.FindById(position.DishId).Name}\" #{position.Quantity}";
    }
}