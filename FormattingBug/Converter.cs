using System.Globalization;
using System.Text.RegularExpressions;

namespace FormattingBug;

public class DecimalCurrencyConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return decimal.Parse(value.ToString()).ToString("c2", culture);
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        var isNegative = Regex.IsMatch(value.ToString(), "^-", RegexOptions.CultureInvariant);
        var valueFromString = Regex.Replace(value.ToString(), @"\$|,", "");

        if (string.IsNullOrEmpty(valueFromString))
        {
            return 0m;
        }

        return valueFromString.Length <= 0
            ? 0m
            : !decimal.TryParse(valueFromString, out var decimalVal) ? 0m : (object)(isNegative ? decimalVal * -1 : decimalVal);
    }
}
