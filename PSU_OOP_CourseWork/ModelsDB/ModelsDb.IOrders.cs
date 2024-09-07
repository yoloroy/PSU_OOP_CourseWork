using System.Collections.Generic;
using System.Collections.ObjectModel;
using PSU_OOP_CourseWork.DB;
using PSU_OOP_CourseWork.Models;
using PSU_OOP_CourseWork.Models.Datums;

namespace PSU_OOP_CourseWork.ModelsDB;

public partial class ModelsDb(SqlService service) : IOrders
{
    /// <summary>
    /// <inheritdoc cref="IOrders.Items"/>
    /// </summary>
    ReadOnlyObservableCollection<Order> IOrders.Items { get; } = service.Orders;

    /// <summary>
    /// <inheritdoc cref="IOrders.Push"/>
    /// </summary>
    void IOrders.Push(IEnumerable<OrderPosition> positions) => service.PushOrder(positions);

    /// <summary>
    /// <inheritdoc cref="IOrders.Remove"/>
    /// </summary>
    void IOrders.Remove(int id) => service.RemoveOrder(id);
}