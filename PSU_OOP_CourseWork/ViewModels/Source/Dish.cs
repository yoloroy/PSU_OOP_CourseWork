namespace PSU_OOP_CourseWork.ViewModels.Source;

/// <summary>
/// Блюда
/// </summary>
/// <param name="Id">Идентификатор</param>
/// <param name="Name">Наименование</param>
/// <param name="Description">Описание</param>
/// <param name="PriceRoubles">Цена в рублях</param>
public readonly record struct Dish
(
    int Id,
    string Name,
    string Description,
    decimal PriceRoubles
);