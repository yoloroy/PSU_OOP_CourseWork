using System;

namespace PSU_OOP_CourseWork.Util;

/// <summary>
/// Расширяющий класс для работы с классами времени
/// </summary>
public static class TimeExtension
{
    /// <summary>
    /// Фабричный метод создания времени из числа (kotlin-like)
    /// </summary>
    /// <param name="hours">Часы</param>
    /// <returns>Время</returns>
    public static TimeSpan Hours(this int hours) => new(hours, 0, 0);

    /// <summary>
    /// Обрезает DateTime до только времени (TimeOnly)
    /// </summary>
    /// <param name="dateTime">Дата и время</param>
    /// <returns>TimeOnly -- только время</returns>
    public static TimeOnly OnlyTime(this DateTime dateTime) => TimeOnly.FromDateTime(dateTime);

    /// <summary>
    /// Обрезает DateTime до только даты (DateOnly)
    /// </summary>
    /// <param name="dateTime">Дата и время</param>
    /// <returns>TimeOnly -- только дату</returns>
    public static DateOnly OnlyDate(this DateTime dateTime) => DateOnly.FromDateTime(dateTime);

    /// <summary>
    /// Возвращает указанную дату, если она больше или равна заданному минимальному значению; 
    /// в противном случае возвращает минимальное значение.
    /// </summary>
    /// <param name="dateTime">Дата, которую необходимо проверить.</param>
    /// <param name="minConstraint">Минимально допустимая дата.</param>
    /// <returns>Если <paramref name="dateTime"/> больше или равен <paramref name="minConstraint"/>, 
    /// возвращает <paramref name="dateTime"/>; в противном случае возвращает <paramref name="minConstraint"/>.</returns>
    public static DateTime AtLeast(this DateTime dateTime, DateTime minConstraint) => dateTime >= minConstraint ? dateTime : minConstraint;
}
