using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using ScottPlot;

namespace PSU_OOP_CourseWork.Views;

/// <summary>
/// Общее диалогоое окно для графиков на базе ScottPlot
/// </summary>
public partial class ScottPlotDialog : Window
{
    /// <summary>
    /// Событие, когда график <see cref="Plot"/> готов к заполнению 
    /// </summary>
    public event Action<Plot>? PlotReady;

    /// <summary>
    /// Конструктор с запуском инициализации
    /// </summary>
    public ScottPlotDialog()
    {
        InitializeComponent();
        Activated += delegate
        {
            Plot.Reset();
            PlotReady?.Invoke(Plot.Plot); ;
            Plot.Refresh();
        };
    }

    /// <summary>
    /// Конструктор с подпиской на конец инициализации
    /// </summary>
    /// <param name="onPlotReady"></param>
    public ScottPlotDialog(Action<Plot> onPlotReady) : this() => PlotReady += onPlotReady;

    private void OnClose(object? _1, RoutedEventArgs _2) => Close();

    /// <summary>
    /// Фабрика диалоговых окон графиков
    /// </summary>
    /// <param name="onPlotReady"></param>
    public class Factory(Action<Plot> onPlotReady)
    {
        /// <summary>
        /// Создаёт диалоговое окно графиков
        /// </summary>
        /// <returns></returns>
        public ScottPlotDialog Produce() => new (onPlotReady);
    }
}