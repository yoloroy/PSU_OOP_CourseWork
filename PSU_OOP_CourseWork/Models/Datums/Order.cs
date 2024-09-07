using System;
using System.Collections.Immutable;

namespace PSU_OOP_CourseWork.Models.Datums;

/// <summary>
/// Представление заказа для области Models
/// </summary>
/// <param name="Id">Идентификатор заказа в БД</param>
/// <param name="Dishes">Блюда, указанные при заказе</param>
/// <param name="CostRoubles">Стоимость на момент оформления</param>
/// <param name="DateTime">Дата и время оформления</param>
public readonly record struct Order
(
    int Id,
    ImmutableArray<OrderPosition> Dishes,
    decimal CostRoubles,
    DateTime DateTime
);