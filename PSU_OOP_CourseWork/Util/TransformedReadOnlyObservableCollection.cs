using System.Collections.Specialized;
using System.Linq;
using DynamicData;

namespace PSU_OOP_CourseWork.Util;

using System;
using System.Collections.ObjectModel;

/// <summary>
/// Представляет коллекцию, которая является только для чтения и содержит преобразованные элементы из исходной коллекции.
/// </summary>
/// <typeparam name="T">Тип элементов в исходной коллекции.</typeparam>
/// <typeparam name="R">Тип элементов в преобразованной коллекции.</typeparam>
public class TransformedReadOnlyObservableCollection<T, R> : ReadOnlyObservableCollection<R>
{
    /// <summary>
    /// Конструктор из изменяемой коллекции <see cref="ObservableCollection{T}"/>
    /// в <see cref="TransformedReadOnlyObservableCollection{T, R}"/>.
    /// </summary>
    /// <param name="source">Коллекция для трасформации.</param>
    /// <param name="transformer">Функция преобразования <typeparamref name="T"/> в <typeparamref name="R"/>.</param>
    public TransformedReadOnlyObservableCollection(ReadOnlyObservableCollection<T> source, Func<T, R> transformer) : base([])
    {
        Items.AddRange(source.Select(transformer));

        ((INotifyCollectionChanged) source).CollectionChanged += (_, _) =>
        {
            Items.Clear();
            Items.AddRange(source.Select(transformer));
        };
    }

    /// <summary>
    /// Конструктор из неизменяемой коллекции <see cref="ObservableCollection{T}"/>
    /// в <see cref="TransformedReadOnlyObservableCollection{T, R}"/>.
    /// </summary>
    /// <param name="source">Коллекция для трасформации.</param>
    /// <param name="transformer">Функция преобразования <typeparamref name="T"/> в <typeparamref name="R"/>.</param>
    public TransformedReadOnlyObservableCollection(ObservableCollection<T> source, Func<T, R> transformer) : base([])
    {
        Items.AddRange(source.Select(transformer));

        ((INotifyCollectionChanged) source).CollectionChanged += (_, _) =>
        {
            Items.Clear();
            Items.AddRange(source.Select(transformer));
        };
    }
}

/// <summary>
/// Расширяющие методы для удобной трансформации обозреваемых коллекций
/// </summary>
public static class TransformedReadOnlyObservableCollection
{
    /// <summary>
    /// Transforms the elements of a <see cref="ReadOnlyObservableCollection{T}"/> into a new <see cref="ReadOnlyObservableCollection{R}"/>.
    /// </summary>
    /// <typeparam name="T">The type of elements in the source collection.</typeparam>
    /// <typeparam name="R">The type of elements in the transformed collection.</typeparam>
    /// <param name="source">The source collection to transform.</param>
    /// <param name="transformer">The function used to transform each element from type <typeparamref name="T"/> to type <typeparamref name="R"/>.</param>
    /// <returns>A new transformed read-only observable collection.</returns>
    public static ReadOnlyObservableCollection<R> Transformed<T, R>(this ReadOnlyObservableCollection<T> source,
        Func<T, R> transformer) =>
        new TransformedReadOnlyObservableCollection<T, R>(source, transformer);

    /// <summary>
    /// Transforms the elements of an <see cref="ObservableCollection{T}"/> into a new <see cref="ReadOnlyObservableCollection{R}"/>.
    /// </summary>
    /// <typeparam name="T">The type of elements in the source collection.</typeparam>
    /// <typeparam name="R">The type of elements in the transformed collection.</typeparam>
    /// <param name="source">The source collection to transform.</param>
    /// <param name="transformer">The function used to transform each element from type <typeparamref name="T"/> to type <typeparamref name="R"/>.</param>
    /// <returns>A new transformed read-only observable collection.</returns>
    public static ReadOnlyObservableCollection<R> Transformed<T, R>(this ObservableCollection<T> source,
        Func<T, R> transformer) =>
        new TransformedReadOnlyObservableCollection<T, R>(source, transformer);

    /// <summary>
    /// Converts an <see cref="ObservableCollection{T}"/> into a read-only observable collection without transformation.
    /// </summary>
    /// <typeparam name="T">The type of elements in the source collection.</typeparam>
    /// <param name="source">The source collection to convert.</param>
    /// <returns>A new read-only observable collection containing the same elements as the source.</returns>
    public static ReadOnlyObservableCollection<T> TransformedToReadonly<T>(this ObservableCollection<T> source) =>
        new TransformedReadOnlyObservableCollection<T, T>(source, x => x);
}
