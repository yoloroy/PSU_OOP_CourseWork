using System.Collections.ObjectModel;

namespace PSU_OOP_CourseWork.ViewModels.Source;

/// <summary>
/// Интерфейс для подписи на блюда меню
/// </summary>
public interface IMenu
{
    /// <summary>
    /// Автообновляемые блюда в меню
    /// </summary>
    public ReadOnlyObservableCollection<Dish> Data { get; }
}