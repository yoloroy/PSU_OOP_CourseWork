using System;
using Avalonia.Controls;
using MsBox.Avalonia;
using MsBox.Avalonia.Enums;
using PSU_OOP_CourseWork.ViewModels;
using PSU_OOP_CourseWork.ViewModels.Rows;

namespace PSU_OOP_CourseWork.Views;

/// <summary>
/// UI Заказы
/// </summary>
public partial class Orders : UserControl, CurrentTable
{
    /// <summary>
    /// Событие удаления заказа по идентификатору
    /// </summary>
    public event Action<int>? Removed;

    private const string AttentionTitle = "Внимание";
    private const string BeWareMessage = "Вы уверены, что хотите удалить данные о заказе \"{0}\" под номером #{1}?";

    /// <summary>
    /// ViewModel
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    public new OrdersViewModel DataContext
    {
        get => base.DataContext as OrdersViewModel ?? throw new NotImplementedException("TODO assign in App.axaml.cs");
        set => base.DataContext = value;
    }

    /// <summary>
    /// Заказы
    /// </summary>
    public Orders()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Deprecated
    /// </summary>
    /// <param name="badRow"></param>
    /// <exception cref="ArgumentNullException"></exception>
    public async void Remove(OrderRow? badRow)
    {
        var row = badRow ?? throw new ArgumentNullException(nameof(badRow));

        var isContinueButtonResult = await MessageBoxManager
            .GetMessageBoxStandard(AttentionTitle, string.Format(BeWareMessage, row.Description, row.Id), ButtonEnum.OkCancel)
            .ShowWindowAsync();

        if (isContinueButtonResult == ButtonResult.Cancel)
        {
            return;
        }

        Removed?.Invoke(row.Id);
    }
}