using System.Collections.ObjectModel;
using PSU_OOP_CourseWork.Models;
using PSU_OOP_CourseWork.Models.Datums;

namespace PSU_OOP_CourseWork.ModelsDB;

/// <summary>
/// Мост меж слоями БД и Модели
/// </summary>
/// <param name="service"></param>
public partial class ModelsDb : IMenu
{
    /// <summary>
    /// <inheritdoc cref="IMenu.Items"/>
    /// </summary>
    ReadOnlyObservableCollection<Dish> IMenu.Items { get; } = service.Dishes;

    /// <summary>
    /// <inheritdoc cref="IMenu.ChangePrice"/>
    /// </summary>
    void IMenu.ChangePrice(int id, decimal priceRoubles) => service.ChangeDishPrice(id, priceRoubles);

    /// <summary>
    /// <inheritdoc cref="IMenu.Remove"/>
    /// </summary>
    void IMenu.Remove(int id) => service.RemoveDish(id);
}