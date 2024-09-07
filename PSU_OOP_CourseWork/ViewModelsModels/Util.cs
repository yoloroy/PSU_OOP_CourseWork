using System.Collections.Generic;
using System.Linq;
using PSU_OOP_CourseWork.Models.Datums;

namespace PSU_OOP_CourseWork.ViewModelsModels;

/// <summary>
/// Утилиты
/// </summary>
public static class Util
{
    // FIXME FindById and FindById could be refactored by using common interface IId

    /// <summary>
    /// Поиск блюда по id
    /// </summary>
    /// <param name="source">Блюда</param>
    /// <param name="id">Идентификатор искомого</param>
    /// <returns>Искомое блюдо</returns>
    public static Dish FindById(this IEnumerable<Dish> source, int id) => source.First(dish => dish.Id == id);

    /// <summary>
    /// Поиск заказа по id
    /// </summary>
    /// <param name="source">Заказы</param>
    /// <param name="id">Идентификатор заказа</param>
    /// <returns>Искомый заказ</returns>
    public static Order FindById(this IEnumerable<Order> source, int id) => source.First(order => order.Id == id);
}