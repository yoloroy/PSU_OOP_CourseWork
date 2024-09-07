using System;
using System.Globalization;
using PSU_OOP_CourseWork.ViewModels.Source;

namespace PSU_OOP_CourseWork.ViewModels.Rows;

/// <summary>
/// Заказ
/// </summary>
/// <param name="Id">Идентификатор</param>
/// <param name="Description">Описание</param>
/// <param name="CostAtATimeRoubles">Цена во время заказа в рублях</param>
/// <param name="Time">Время заказа</param>
/// <param name="Date">Дата заказа</param>
public readonly record struct OrderRow(
    int Id,
    string Description,
    decimal CostAtATimeRoubles,
    TimeOnly Time,
    DateOnly Date
)
{
    /// <summary>
    /// Отформатированная цена
    /// </summary>
    public string FormattedCost => string.Format(new CultureInfo("ru-RU"), "{0:C2}", CostAtATimeRoubles);

    /// <summary>
    /// Отформатированная дата
    /// </summary>
    public string FormattedDate => string.Format(new CultureInfo("ru-Ru"), "{0:d MMMM yyyy, dddd}", Date);

    internal static OrderRow FromSource(Order order) => new(order.Id, order.Description, order.CostAtATimeRoubles, order.Time, order.Date);
}