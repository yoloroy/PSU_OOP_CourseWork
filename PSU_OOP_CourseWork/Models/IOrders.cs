using System.Collections.Generic;
using System.Collections.ObjectModel;
using PSU_OOP_CourseWork.Models.Datums;
using VMSource = PSU_OOP_CourseWork.ViewModels.Source;

namespace PSU_OOP_CourseWork.Models;

/// <summary>
/// Интерфейс для представления заказов и работы с ними
/// </summary>
public interface IOrders
{
    /// <summary>
    /// Заказы
    /// </summary>
    public ReadOnlyObservableCollection<Order> Items { get; }

    /// <summary>
    /// Добавление нового заказа
    /// </summary>
    /// <param name="positions">Позиции блюд, указанные в заказе</param>
    public void Push(IEnumerable<OrderPosition> positions);

    /// <summary>
    /// Удаление заказа по идентификатору
    /// </summary>
    /// <param name="id">Идентификатор заказа</param>
    public void Remove(int id);
}