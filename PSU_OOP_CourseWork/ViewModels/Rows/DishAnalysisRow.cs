using PSU_OOP_CourseWork.ViewModels.Source;

namespace PSU_OOP_CourseWork.ViewModels.Rows;

/// <summary>
/// 
/// </summary>
/// <param name="Id"></param>
/// <param name="Name"></param>
/// <param name="OrdersCount"></param>
public readonly record struct DishAnalysisRow(
    int Id,
    string Name,
    int OrdersCount
)
{
    internal static DishAnalysisRow FromSource(AnalyzedDish dish) => new(dish.Id, dish.Name, dish.Count);
};