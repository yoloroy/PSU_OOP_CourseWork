using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using Avalonia.Controls;
using Avalonia.Interactivity;
using MsBox.Avalonia;
using MsBox.Avalonia.Enums;
using PSU_OOP_CourseWork.ViewModels;
using PSU_OOP_CourseWork.ViewModels.Rows;

namespace PSU_OOP_CourseWork.Views;

/// <summary>
/// Меню ui
/// </summary>
public partial class Menu : UserControl, CurrentTable
{
    /// <summary>
    /// Событие заказа
    /// </summary>
    public event Action<Dictionary<int, int>>? Ordered;

    /// <summary>
    /// Событие изменение цены блюда по идентификатору
    /// </summary>
    public event Action<int, decimal>? PriceChanged;

    /// <summary>
    /// Событие удаления блюда
    /// </summary>
    public event Action<int>? Removed;

    private const string AttentionTitle = "Внимание";
    private const string BeWareOfForeignKeysMessage = "Вы уверены, что хотите удалить блюдо \"{0}\"?";
    private const string MistakeTitle = "Ошибка";
    private const string ForeignKeysErrorMessage = "Удалите заказы, упоминающие блюдо \"{0}\" чтобы можно было удалить его.";

    /// <summary>
    /// Модель данных меню
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    public new MenuViewModel DataContext
    {
        get => base.DataContext as MenuViewModel ?? throw new NotImplementedException("TODO assign in App.axaml.cs");
        set => base.DataContext = value;
    }

    /// <summary>
    /// Пустой конструктор
    /// </summary>
    public Menu()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Метод для инициализации, когда все источники данных уже актины
    /// </summary>
    public void Ready()
    {
        OrderButton.IsEnabled = DataContext.Rows.Any(row => row.InCart > 0);
        DataContext.Rows.ListChanged += OnRowsItemChanged;
    }

    private void OnRowsItemChanged(object? _, ListChangedEventArgs args)
    {
        if (args.ListChangedType != ListChangedType.ItemChanged)
        {
            return;
        }

        OrderButton.IsEnabled = DataContext.Rows.Any(row => row.InCart > 0);
    }

    private void OnPushedNewOrder(object? _1, RoutedEventArgs _2)
    {
        var orderPositions = DataContext.Rows
            .Where(row => row.InCart > 0)
            .ToDictionary(row => row.Id, row => row.InCart);
    
        Ordered?.Invoke(orderPositions);
        foreach (var row in DataContext.Rows.ToArray())
        {
            row.InCart = 0;
        }
    }

    private void OnCellEdited(object? _, DataGridCellEditEndedEventArgs e)
    {
        var i = e.Row.GetIndex();
        // Showing change
        DataContext.Rows[i] = DataContext.Rows[i];
    }

    /// <summary>
    /// Метод изменения цены со стороны ui в направление данных
    /// </summary>
    /// <param name="row">Изменённая строка</param>
    public void OnPriceChanged(DishRow? row)
    {
        Debug.Assert(row != null, nameof(row) + " != null");
        PriceChanged?.Invoke(row.Id, row.PriceRoubles);
    }

    /// <summary>
    /// NotUsed
    /// </summary>
    /// <param name="row"></param>
    public async void Remove(DishRow? row)
    {
        Debug.Assert(row != null, nameof(row) + " != null");
        var isContinueButtonResult = await MessageBoxManager
            .GetMessageBoxStandard(AttentionTitle, string.Format(BeWareOfForeignKeysMessage, row.Name), ButtonEnum.OkCancel)
            .ShowWindowAsync();

        if (isContinueButtonResult == ButtonResult.Cancel)
        {
            return;
        }

        try
        {
            Removed?.Invoke(row.Id);
        }
        catch (ConstraintException)
        {
            _ = MessageBoxManager
                .GetMessageBoxStandard(MistakeTitle, string.Format(ForeignKeysErrorMessage, row.Name))
                .ShowWindowAsync();
        }
    }
}