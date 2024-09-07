namespace PSU_OOP_CourseWork.ViewModels.Source;

/// <summary>
/// Представление блюда для Аналитики
/// </summary>
/// <param name="Id">Идентификатор блюда</param>
/// <param name="Name">Наименование блюда</param>
/// <param name="Count">Количество заказов сего блюда</param>
public readonly record struct AnalyzedDish(int Id, string Name, int Count);