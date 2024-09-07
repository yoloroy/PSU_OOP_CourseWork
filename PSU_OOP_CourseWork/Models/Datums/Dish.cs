namespace PSU_OOP_CourseWork.Models.Datums;

/// <summary>
/// Представление блюда для области Models
/// </summary>
/// <param name="Id">Идентификатор блюда в БД</param>
/// <param name="Name">Название блюда</param>
/// <param name="Description">Описание блюда</param>
/// <param name="PriceRoubles">Цена блюда в рублях</param>
public readonly record struct Dish
(
    int Id,
    string Name,
    string Description,
    decimal PriceRoubles
);