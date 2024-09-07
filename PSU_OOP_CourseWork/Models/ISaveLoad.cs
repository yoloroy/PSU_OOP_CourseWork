namespace PSU_OOP_CourseWork.Models;
 
/// <summary>
/// Интерфейс для работы с Сохранением/Загрузкой
/// </summary>
public interface ISaveLoad
{
    /// <summary>
    /// Выгрузка данных
    /// </summary>
    public void Save();

    /// <summary>
    /// Загрузка данных
    /// </summary>
    public void Load();
}