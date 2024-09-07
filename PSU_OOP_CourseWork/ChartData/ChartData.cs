using System;
using System.Collections.Generic;
using System.Linq;
using ScottPlot;

namespace PSU_OOP_CourseWork.ChartData;

/// <summary>
/// Класс для работы с графическими данными и их применением к графикам на ScottPlot.
/// </summary>
public static class ChartData
{
    /// <summary>
    /// Метод расширения для получения популярности по заданному ключу.
    /// </summary>
    /// <typeparam name="TKey">Тип ключа, по которому производится группировка.</typeparam>
    /// <param name="times">Список временных меток.</param>
    /// <param name="selector">Функция, выбирающая ключ из временной метки.</param>
    /// <returns>Список значений популярности в виде <see cref="IEnumerable{Double}"/>.</returns>
    public static IEnumerable<double> PopularityBy<TKey>(this IEnumerable<DateTime> times, Func<DateTime, TKey> selector) where TKey : IComparable<TKey>
    {
        var groups = times.GroupBy(selector).ToList();
        groups.Sort((a, b) => a.Key.CompareTo(b.Key));

        return groups
            .Select(Enumerable.Count)
            .Select(Convert.ToDouble);
    }

    /// <summary>
    /// Добавляет график популярности по часам на указанный график.
    /// </summary>
    /// <param name="plot">График, на который будет добавлен график популярности.</param>
    /// <param name="times">Список временных меток.</param>
    public static void AddPopularityByHour(this Plot plot, IEnumerable<DateTime> times)
    {
        var slices = times
            .PopularityBy(time => time.Hour)
            .Select((value, hour) => new PieSlice(value, ColorOfHour(hour), hour.ToString()))
            .ToList();

        var pie = plot.Add.Pie(slices);
        pie.ShowSliceLabels = true;
        return;

        // Ближе к ночи - темнее и синее, ближе к полудню - светлее и желтее
        Color ColorOfHour(int hour) => Colors.MidnightBlue.MixedWith(Colors.FloralWhite, Math.Abs(12 - hour) / 12d);
    }

    /// <summary>
    /// Добавляет график популярности по дням недели на указанный график.
    /// </summary>
    /// <param name="plot">График, на который будет добавлен график популярности.</param>
    /// <param name="times">Список временных меток.</param>
    public static void AddPopularityByDayOfWeek(this Plot plot, IEnumerable<DateTime> times)
    {
        var colors = new[] { Colors.DarkCyan, Colors.IndianRed, Colors.PaleGreen, Colors.CadetBlue, Colors.DarkOliveGreen, Colors.Yellow, Colors.Red };
        var slices = times
            .PopularityBy(time => ((int) time.DayOfWeek + 1) % 7) // Конверсия номеров дней недели в ISO 8601
            .Select((value, dayOfWeek) => new PieSlice(value, colors[dayOfWeek], dayOfWeek.ToString()))
            .ToList();

        var pie = plot.Add.Pie(slices);
        pie.ShowSliceLabels = true;
    }

    /// <summary>
    /// Добавляет график популярности по месяцам на указанный график.
    /// </summary>
    /// <param name="plot">График, на который будет добавлен график популярности.</param>
    /// <param name="times">Список временных меток.</param>
    public static void AddPopularityByMonth(this Plot plot, IEnumerable<DateTime> times)
    {
        var colors = new[]
        {
            Colors.AliceBlue, // Январь
            Color.FromHex("#287fbd"), // Февраль
            Colors.CadetBlue, // Март
            Colors.DarkOliveGreen, // Апрель
            Colors.PaleGreen, // Май
            Colors.Yellow, // Июнь
            Colors.NavajoWhite, // Июнь
            Colors.Crimson, // Август
            Colors.BurlyWood, // Сентябрь
            Colors.IndianRed, // Октябрь
            Colors.SlateGray, // Ноябрь
            Colors.PaleTurquoise, // Декабрь
        };
        var slices = times
            .PopularityBy(time => time.Month)
            .Select((value, month) => new PieSlice(value, colors[month], month.ToString()))
            .ToList();

        var pie = plot.Add.Pie(slices);
        pie.ShowSliceLabels = true;
    }
}
