using System.Collections.Generic;

namespace PSU_OOP_CourseWork.Models.Datums;

/// <summary>
/// Позиция заказанного блюда с его количеством в заказе
/// </summary>
/// <param name="DishId">Идентификатор заказанного блюда</param>
/// <param name="Quantity">Количество заказанных порций</param>
public readonly record struct OrderPosition(
    int DishId,
    int Quantity
)
{
    /// <summary>
    /// Фабричный метод создающий Позицию Заказа из generic структуры KeyValuePair
    /// </summary>
    /// <param name="kv">[int dishId] = (int quantity)</param>
    /// <returns>Позицию Заказа построенную на базе входящей пары</returns>
    public static OrderPosition FromKeyValue(KeyValuePair<int, int> kv) => new(kv.Key, kv.Value);
}