using System.Linq;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using MsBox.Avalonia;
using PSU_OOP_CourseWork.ChartData;
using PSU_OOP_CourseWork.DB;
using PSU_OOP_CourseWork.Models;
using PSU_OOP_CourseWork.Models.Datums;
using PSU_OOP_CourseWork.ModelsDB;
using PSU_OOP_CourseWork.Util;
using VM = PSU_OOP_CourseWork.ViewModels;
using PSU_OOP_CourseWork.Views;
using VMM = PSU_OOP_CourseWork.ViewModelsModels;

namespace PSU_OOP_CourseWork;

/// <inheritdoc />
public class App : Application
{
    /// <inheritdoc />
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    /// <inheritdoc />
    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            var sqlService = new SqlService();
            var models = new ModelsDb(sqlService);
            IMenu menu = models;
            IOrders orders = models;
            ISaveLoad saveLoad = models;
            var orderTimes = orders.Items.Transformed(order => order.DateTime);

            var mainWindow = new MainWindow
            (
                new MenuAnalysisDialog.Factory(new VMM.MenuAnalysis(models, models)),
                new ScottPlotDialog.Factory(plot => plot.AddPopularityByHour(orderTimes)),
                new ScottPlotDialog.Factory(plot => plot.AddPopularityByDayOfWeek(orderTimes)),
                new ScottPlotDialog.Factory(plot => plot.AddPopularityByMonth(orderTimes))
            )
            {
                DataContext = new VM.MainWindowViewModel(),
                Orders =
                {
                    DataContext = new VM.OrdersViewModel(new VMM.Orders(orders, menu))
                },
                Dishes =
                {
                    DataContext = new VM.MenuViewModel(new VMM.Menu(models)),
                }
            };
            mainWindow.CurrentTable = mainWindow.Dishes;
            mainWindow.Dishes.Ordered += positions => orders.Push(positions.Select(OrderPosition.FromKeyValue));
            mainWindow.Dishes.PriceChanged += menu.ChangePrice;
            mainWindow.Dishes.Removed += menu.Remove;
            mainWindow.Dishes.Ready();
            mainWindow.Orders.Removed += orders.Remove;
            mainWindow.SaveAsked += saveLoad.Save;
            mainWindow.LoadAsked += saveLoad.Load;
            desktop.MainWindow = mainWindow;

            MessageBoxManager
                .GetMessageBoxStandard("Приветствие", "Этот проект является курсовой работой, выполненной Ларюшкиным Сергеем 21ВП1 по дисциплине \"Объектно-ориентированное программирование\" по теме \"Ресторан\"")
                .ShowWindowAsync();
        }

        base.OnFrameworkInitializationCompleted();
    }
}