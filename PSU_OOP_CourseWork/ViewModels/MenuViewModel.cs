using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using DynamicData.Binding;
using PSU_OOP_CourseWork.Util;
using PSU_OOP_CourseWork.ViewModels.Rows;
using PSU_OOP_CourseWork.ViewModels.Source;

namespace PSU_OOP_CourseWork.ViewModels;

/// <summary>
/// ViewModel Меню
/// </summary>
public partial class MenuViewModel : ViewModelBase
{
    /// <summary>
    /// Отображаемые в табоице блюда
    /// </summary>
    public BindingList<DishRow> Rows { get; }

    /// <summary>
    /// Конструктор обозреваемых блюд из модели
    /// </summary>
    /// <param name="menu"></param>
    public MenuViewModel(IMenu menu)
    {
        Rows = [..menu.Data.Select(DishRow.FromSource)];
        var updatedRows = menu.Data.Transformed(DishRow.FromSource);
        updatedRows.ObserveCollectionChanges().Subscribe(delegate { ApplyPatch(updatedRows.ToArray()); });
    }

    internal MenuViewModel() : this(StubMenu)
    {
    }

    internal static readonly IMenu StubMenu = new MenuStubImpl();

    private class MenuStubImpl : IMenu
    {
        public ReadOnlyObservableCollection<Dish> Data { get; } = new
        ([
            new(0, "Макароны Сырые", "Сырые", 1000),
            new(1, "Макароны Мокрые", "Мокрые", 2000),
            new(2, "Макароны Готовые", "Готовые", 3000),
            new(3, "Макароны Полусухие", "Аль-денте", 4000)
        ]);
    }
}