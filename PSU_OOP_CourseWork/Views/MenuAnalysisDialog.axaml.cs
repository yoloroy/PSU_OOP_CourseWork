using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using PSU_OOP_CourseWork.ViewModels;
using PSU_OOP_CourseWork.ViewModels.Source;

namespace PSU_OOP_CourseWork.Views;

/// <summary>
/// Диалог аналитики меню
/// </summary>
public partial class MenuAnalysisDialog : Window
{
    /// <summary>
    /// ViewModel
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    public new MenuAnalysisDialogViewModel DataContext
    {
        get => base.DataContext as MenuAnalysisDialogViewModel ?? throw new NotImplementedException("TODO assign in App.axaml.cs");
        set => base.DataContext = value;
    }

    /// <summary>
    /// Конструктор с ViewModel
    /// </summary>
    /// <param name="dataContext"></param>
    public MenuAnalysisDialog(MenuAnalysisDialogViewModel dataContext)
    {
        DataContext = dataContext;
        InitializeComponent();
    }

    private void OnExit(object? _1, RoutedEventArgs _2) => Close();

    /// <summary>
    /// Фабрица диалога аналитики меню 
    /// </summary>
    /// <param name="analysis"></param>
    public class Factory(IMenuAnalysis analysis)
    {
        /// <summary>
        /// Создание продукта фабрики
        /// </summary>
        /// <returns>MenuAnalysisDialog</returns>
        public MenuAnalysisDialog Produce() => new(new MenuAnalysisDialogViewModel(analysis));
    }

    private void OnStartDateSelected(object? _, DatePickerSelectedValueChangedEventArgs e)
    {
        DataContext.StartDate = e.NewDate ?? DateTimeOffset.Now;
    }

    private void OnEndDateSelected(object? _, DatePickerSelectedValueChangedEventArgs e)
    {
        DataContext.EndDate = e.NewDate ?? DateTimeOffset.Now;
    }
}