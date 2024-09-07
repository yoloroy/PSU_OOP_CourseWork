using System;
using System.Collections.ObjectModel;
using PSU_OOP_CourseWork.Util;
using PSU_OOP_CourseWork.ViewModels.Rows;
using PSU_OOP_CourseWork.ViewModels.Source;

namespace PSU_OOP_CourseWork.ViewModels;

/// <summary>
/// ViewModel Заказов
/// </summary>
/// <param name="orders">Модель заказов</param>
public class OrdersViewModel(IOrders orders) : ViewModelBase
{
    /// <summary>
    /// Строки для таблицы заказов
    /// </summary>
    public ReadOnlyObservableCollection<OrderRow> Rows { get; } = orders.Data.Transformed(OrderRow.FromSource);

    /// <summary>
    /// Конструктор для debug'а
    /// </summary>
    public OrdersViewModel() : this(StubOrders)
    {
    }

    internal static readonly IOrders StubOrders = new OrdersStubImpl();
    private class OrdersStubImpl : IOrders
    {
        public ReadOnlyObservableCollection<Order> Data { get; } = new
        ([
            new(0, "Макароны Полусухие x2;Макароны Мокрые x2", 12000m, DateTime.Now.Add(-2.Hours())),
            new(1, "Макароны Полусухие x2;Макароны Мокрые x2", 12000m, DateTime.Now.Add(-1.Hours()))
        ]);
    }
}