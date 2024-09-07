using System;
using System.Linq;
using Avalonia.Controls;
using Avalonia.Interactivity;
using PSU_OOP_CourseWork.ViewModels;

namespace PSU_OOP_CourseWork.Views;

/// <summary>
/// Окно
/// </summary>
public partial class MainWindow : Window
{
    /// <summary>
    /// Событие нажатия сохранения
    /// </summary>
    public event Action? SaveAsked;

    /// <summary>
    /// Событие нажатия загрузки
    /// </summary>
    public event Action? LoadAsked;

    /// <summary>
    /// Данные ViewModel'и
    /// </summary>
    /// <exception cref="NotImplementedException">TODO assign in App.axaml.cs</exception>
    public new MainWindowViewModel DataContext
    {
        get => base.DataContext as MainWindowViewModel ?? throw new NotImplementedException("TODO assign in App.axaml.cs");
        set => base.DataContext = value;
    }

    /// <summary>
    /// Выбранная в данный момент таблица
    /// </summary>
    public ContentControl CurrentTable
    {
        set
        {
            foreach (var tableControl in Body.Children.Where(child => child is CurrentTable))
            {
                tableControl.IsVisible = false;
            }

            value.IsVisible = true;
        }
    }

    private readonly MenuAnalysisDialog.Factory madFactory;
    private readonly ScottPlotDialog.Factory ordersChartByHourFactory;
    private readonly ScottPlotDialog.Factory ordersChartByDayOfWeekFactory;
    private readonly ScottPlotDialog.Factory ordersChartByMonthFactory;

    /// <summary>
    /// Полный конструктор основного окна
    /// </summary>
    /// <param name="madFactory">Безумная фабрика</param>
    /// <param name="ordersChartByHourFactory">Фабрика диалога с графиком по часам</param>
    /// <param name="ordersChartByDayOfWeekFactory">Фабрика диалога с графиком по дням недели</param>
    /// <param name="ordersChartByMonthFactory">Фабрика диалога с графиком заказов по месяцам</param>
    public MainWindow
    (
        MenuAnalysisDialog.Factory madFactory,
        ScottPlotDialog.Factory ordersChartByHourFactory,
        ScottPlotDialog.Factory ordersChartByDayOfWeekFactory,
        ScottPlotDialog.Factory ordersChartByMonthFactory
    )
    {
        this.madFactory = madFactory;
        this.ordersChartByHourFactory = ordersChartByHourFactory;
        this.ordersChartByDayOfWeekFactory = ordersChartByDayOfWeekFactory;
        this.ordersChartByMonthFactory = ordersChartByMonthFactory;
        InitializeComponent();
    }

    private void Save(object? _1, RoutedEventArgs _2) => SaveAsked?.Invoke();
    private void Load(object? _1, RoutedEventArgs _2) => LoadAsked?.Invoke();
    private void ShowMenu(object? _1, RoutedEventArgs _2) => CurrentTable = Dishes;
    private void ShowOrders(object? _1, RoutedEventArgs _2) => CurrentTable = Orders;

    private void ShowMenuAnalysisDialog(object? _1, RoutedEventArgs _2) => madFactory.Produce().Show();

    private void ShowOrdersChartByHour(object? _1, RoutedEventArgs _2) => ordersChartByHourFactory.Produce().Show();

    private void ShowOrdersChartByDayOfWeek(object? _1, RoutedEventArgs _2) => ordersChartByDayOfWeekFactory.Produce().Show();

    private void ShowOrdersChartByMonth(object? _1, RoutedEventArgs _2) => ordersChartByMonthFactory.Produce().Show();
}