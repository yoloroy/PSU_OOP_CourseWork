using System.Collections.ObjectModel;
using PSU_OOP_CourseWork.Models.Datums;

namespace PSU_OOP_CourseWork.Models;

/// <summary>
/// Интерфейс для представления меню, его блюда и интерфейс работы с ними.
/// </summary>
public interface IMenu
{
    /// <summary>
    /// Коллекция блюд в меню.
    /// </summary>
    ReadOnlyObservableCollection<Dish> Items { get; }

    /// <summary>
    /// Изменяет цену блюда по заданному идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор блюда, цену которого необходимо изменить.</param>
    /// <param name="priceRoubles">Новая цена блюда в рублях.</param>
    void ChangePrice(int id, decimal priceRoubles);

    /// <summary>
    /// Удаляет блюдо из меню по заданному идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор блюда, которое необходимо удалить.</param>
    void Remove(int id);
}