using System;
using System.Collections.ObjectModel;
using PSU_OOP_CourseWork.Models.Datums;
using PSU_OOP_CourseWork.Util;

namespace PSU_OOP_CourseWork.Models.Stubs;

public partial class Stubs
{
    private readonly ObservableCollection<Dish> dishes =
    [
        new(0, "Макароны с НеСыром", "Вместо сыра у нас пальмовый майонез", 1_000),
        new(1, "Макароны с Сыром", "Сыр как сыр", 4_000)
    ];

    private readonly ObservableCollection<Order> orders =
    [
        new(0, [new(0, 10), new(1, 4)], 14_000, DateTime.Now),
        new(1, [new(0, 1)], 1_000, DateTime.Now),
        new(2, [new(0, 10), new(1, 4)], 28_000, DateTime.Now + 1.Hours())
    ];
}