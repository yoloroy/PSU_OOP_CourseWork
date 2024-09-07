using System;
using System.Collections.ObjectModel;
using System.Linq;
using DynamicData;
using PSU_OOP_CourseWork.Util;
using M = PSU_OOP_CourseWork.Models;
using VM = PSU_OOP_CourseWork.ViewModels.Source;

namespace PSU_OOP_CourseWork.ViewModelsModels;

/// <summary>
/// Адаптер модели аналитики меню для viewmodel'ного слоя
/// </summary>
public class MenuAnalysis : VM.IMenuAnalysis
{
    /// <summary>
    /// Блюда на отрезке времени
    /// </summary>
    /// <seealso cref="IntervalStart"/>
    /// <seealso cref="IntervalEnd"/>
    public ReadOnlyObservableCollection<VM.AnalyzedDish> DishesStatsOnInterval { get; }

    /// <summary>
    /// Начало отрезка времени для данных аналитики
    /// </summary>
    public DateTime IntervalStart { set { intervalStart = value; RefreshStats(); } }

    /// <summary>
    /// Конец отрезка времени для данных аналитики
    /// </summary>
    public DateTime IntervalEnd { set { intervalEnd = value; RefreshStats(); } }

    private readonly ObservableCollection<VM.AnalyzedDish> dishesStatsOnInterval;
    private DateTime intervalStart = DateTime.MinValue;
    private DateTime intervalEnd = DateTime.MaxValue;

    private readonly M.IMenu menu;
    private readonly M.IOrders orders;

    /// <summary>
    /// Конструктор анализатора меню из модели заказов и модели меню
    /// </summary>
    /// <param name="orders">Модель заказов</param>
    /// <param name="menu">Модель меню</param>
    public MenuAnalysis(M.IOrders orders, M.IMenu menu)
    {
        this.menu = menu;
        this.orders = orders;

        dishesStatsOnInterval = new ObservableCollection<VM.AnalyzedDish>();
        DishesStatsOnInterval = dishesStatsOnInterval.TransformedToReadonly();
    }

    private void RefreshStats()
    {
        dishesStatsOnInterval.Clear();
        dishesStatsOnInterval.AddRange(CalculateForInterval(intervalStart, intervalEnd));
    }

    private VM.AnalyzedDish[] CalculateForInterval(DateTime from, DateTime until)
    {
        var dishesNames = menu.Items.ToDictionary
        (
            keySelector: d => d.Id,
            elementSelector: d => d.Name
        );

        return orders.Items.ToArray()
            .Where(order => order.DateTime >= from && order.DateTime <= until)
            .SelectMany(order => order.Dishes)
            .GroupBy(position => position.DishId)
            .Select
            (
                group => new VM.AnalyzedDish(group.Key, dishesNames[group.Key], group.Sum(p => p.Quantity))
            )
            .ToArray();
    }
}