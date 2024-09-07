using System.Collections.Generic;
using System.Linq;

namespace PSU_OOP_CourseWork.Util;

/// <summary>
/// Расширения для IEnumerable
/// </summary>
public static class IEnumerableExtension
{
    /// <summary>
    /// Создаёт новый IEnumerable, имеющий данные подряд из a и из b
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static IEnumerable<T> AppendAll<T>(this IEnumerable<T> a, IEnumerable<T> b)
    {
        foreach (var x in a) yield return x;
        foreach (var x in b) yield return x;
    }

    /// <summary>
    /// Отфильтровывает элементы == null
    /// </summary>
    /// <param name="source"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static IEnumerable<T> WhereNotNull<T>(this IEnumerable<T?> source) where T : struct => source.Where(element => element.HasValue).Select(element => element!.Value);
}