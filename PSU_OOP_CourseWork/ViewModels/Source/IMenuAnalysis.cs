using System;
using System.Collections.ObjectModel;

namespace PSU_OOP_CourseWork.ViewModels.Source;

/// <summary>
/// Интерфейс источника аналитических данных о блюдах
/// </summary>
public interface IMenuAnalysis
{
    /// <summary>
    /// Аналитические данные о блюдах на отрезке времени
    /// <seealso cref="IntervalStart"/>
    /// <seealso cref="IntervalEnd"/>
    /// </summary>
    public ReadOnlyObservableCollection<AnalyzedDish> DishesStatsOnInterval { get; }

    /// <summary>
    /// Дата начала отрезка просмотра статистики
    /// </summary>
    public DateTime IntervalStart { set; }

    /// <summary>
    /// Дата конца отрезка просмотра статистики
    /// </summary>
    public DateTime IntervalEnd { set; }
}