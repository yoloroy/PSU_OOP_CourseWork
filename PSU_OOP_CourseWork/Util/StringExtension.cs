namespace PSU_OOP_CourseWork.Util;

/// <summary>
/// Расширяющий класс для строк
/// </summary>
public static class StringExtension
{
    /// <summary>
    /// Возвращает пустую строку, если оригинальная строка == null
    /// </summary>
    /// <param name="s">Nullable строка</param>
    /// <returns>Оригинальную строку или пустую строку, если оригинал == null</returns>
    public static string CoalesceEmpty(this string? s) => s ?? "";
}