using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using PSU_OOP_CourseWork.ViewModels.Source;

namespace PSU_OOP_CourseWork.ViewModels.Rows;

/// <summary>
/// Отображаемое в ui блюдо
/// </summary>
/// <param name="id">Идентификатор</param>
/// <param name="name">Наименование</param>
/// <param name="description">Описание</param>
/// <param name="priceRoubles">Цена в рублях</param>
/// <param name="inCart">В корзине?</param>
public sealed class DishRow(int id, string name, string description, decimal priceRoubles, int inCart) : INotifyPropertyChanged
{
    /// <summary>
    /// <inheritdoc cref="INotifyPropertyChanged.PropertyChanged"/>
    /// </summary>
    public event PropertyChangedEventHandler? PropertyChanged;

    /// <summary>
    /// Идентификатор
    /// </summary>
    public int Id { get; } = id;

    /// <summary>
    /// Наименование
    /// </summary>
    public string Name { get; } = name;

    /// <summary>
    /// Описание
    /// </summary>
    public string Description { get; } = description;

    /// <summary>
    /// Цена в рублях
    /// </summary>
    public decimal PriceRoubles { get => priceRoubles; set => SetField(ref priceRoubles, value); }

    /// <summary>
    /// В корзине?
    /// </summary>
    public int InCart { get => inCart; set => SetField(ref inCart, value); }

    /// <summary>
    /// Форматированная цена
    /// </summary>
    public string FormattedPrice => string.Format(new CultureInfo("ru-RU"), "{0:C2}", PriceRoubles);

    /// <summary>
    /// Фабричный метод конвертации из модельного слоя
    /// </summary>
    /// <param name="dish">Блюдо в слое модели</param>
    /// <returns>Блюдо</returns>
    internal static DishRow FromSource(Dish dish) => new(dish.Id, dish.Name, dish.Description, dish.PriceRoubles, 0);

    private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    private void SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value))
        {
            return;
        }
        field = value;
        OnPropertyChanged(propertyName);
    }
}