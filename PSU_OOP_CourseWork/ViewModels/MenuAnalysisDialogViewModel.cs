using System;
using System.Collections.ObjectModel;
using PSU_OOP_CourseWork.Util;
using PSU_OOP_CourseWork.ViewModels.Rows;
using PSU_OOP_CourseWork.ViewModels.Source;

namespace PSU_OOP_CourseWork.ViewModels;

/// <summary>
/// <inheritdoc cref="ViewModelBase"/>
/// </summary>
/// <param name="analysis"></param>
public class MenuAnalysisDialogViewModel(IMenuAnalysis analysis) : ViewModelBase
{
    /// <summary>
    /// Аналитические данные о блюдах 
    /// </summary>
    public ReadOnlyObservableCollection<DishAnalysisRow> Rows { get; } = analysis.DishesStatsOnInterval.Transformed(DishAnalysisRow.FromSource);

    /// <summary>
    /// Дата начала отрезка рассматриваемых данных
    /// </summary>
    public DateTimeOffset StartDate
    {
        get => new(startDate);
        set
        {
            startDate = value.DateTime;
            analysis.IntervalStart = startDate;
        }
    }

    /// <summary>
    /// Дата конца отрезка рассматриваемых данных
    /// </summary>
    public DateTimeOffset EndDate
    {
        get => new(endDate);
        set
        {
            endDate = value.DateTime.AtLeast(startDate);
            analysis.IntervalEnd = endDate;
        }
    }

    private DateTime startDate = DateTime.MinValue;
    private DateTime endDate = DateTime.MaxValue;
}