using DynamicData.Kernel;

namespace PSU_OOP_CourseWork.Util;

/// <summary>
/// Расширяющий класс для разборки структуры ItemWithIndex
/// </summary>
public static class ItemWithIndexDeconstruction
{
    /// <summary>
    /// Деконструктор
    /// </summary>
    /// <param name="self">Деконструируимое</param>
    /// <param name="item">Элемент</param>
    /// <param name="i">Индекс</param>
    /// <typeparam name="T">Тип элемента</typeparam>
    public static void Deconstruct<T>(this ItemWithIndex<T> self, out T item, out int i)
    {
        item = self.Item;
        i = self.Index;
    }
}