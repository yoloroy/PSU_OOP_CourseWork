using System;
using PSU_OOP_CourseWork.Util;

namespace PSU_OOP_CourseWork.ViewModels.Source;

/// <summary>
/// Заказ
/// </summary>
/// <param name="Id">Идентификатор</param>
/// <param name="Description">Описание</param>
/// <param name="CostAtATimeRoubles">Стоимость во время заказа</param>
/// <param name="DateTime">Дата и время заказа</param>
public readonly record struct Order(
    int Id,
    string Description,
    decimal CostAtATimeRoubles,
    DateTime DateTime
)
{
    /// <summary>
    /// Дата заказа
    /// </summary>
    public DateOnly Date => DateTime.OnlyDate();

    /// <summary>
    /// Время заказа
    /// </summary>
    public TimeOnly Time => TimeOnly.FromTimeSpan(DateTime.TimeOfDay);
}