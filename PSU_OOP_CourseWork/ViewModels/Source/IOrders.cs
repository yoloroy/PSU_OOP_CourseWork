using System.Collections.ObjectModel;

namespace PSU_OOP_CourseWork.ViewModels.Source;

/// <summary>
/// Интерфейс для подписи на заказы
/// </summary>
public interface IOrders
{
    /// <summary>
    /// Автообновляемые заказы
    /// </summary>
    public ReadOnlyObservableCollection<Order> Data { get; }
}