using System.Collections.ObjectModel;
using PSU_OOP_CourseWork.Util;
using M = PSU_OOP_CourseWork.Models;
using VM = PSU_OOP_CourseWork.ViewModels.Source;

namespace PSU_OOP_CourseWork.ViewModelsModels;

/// <summary>
/// Адаптер модели меню для viewmodel'ного слоя
/// </summary>
/// <param name="menu"></param>
public sealed class Menu(M.IMenu menu) : VM.IMenu
{
    /// <summary>
    /// Блюда
    /// </summary>
    public ReadOnlyObservableCollection<VM.Dish> Data { get; } = menu.Items.Transformed
    (
        dish =>
        new VM.Dish(
            dish.Id,
            dish.Name,
            dish.Description,
            dish.PriceRoubles
        )
    );
}