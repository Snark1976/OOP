using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace ComplexCalculator.Model.Domain;

/// <summary>
/// Класс комплексного числа.
/// </summary>
public readonly partial struct ComplexNumber(double real = 0, double imaginary = 0)
{
    /// <summary>
    /// Реальная часть комплексного числа.
    /// </summary>
    public double Real { get; } = real;

    /// <summary>
    /// Мнимая часть комплексного числа.
    /// </summary>
    public double Imaginary { get; } = imaginary;

    /// <summary>
    /// Преобразует строковое представление комплексного числа вида "A + Bj", где A и B - действительные числа в объект ComplexNumber.
    /// </summary>
    /// <param name="complexString">Строковое представление комплексного числа.</param>
    /// <returns>Объект ComplexNumber, представляющий комплексное число.</returns>
    public static ComplexNumber Parse(string complexString)
    {
        complexString = complexString.Trim().Replace(" ", "");
        ArgumentException.ThrowIfNullOrEmpty(complexString); 
        Match complex = Complex().Match(complexString);
        if (!complex.Success) throw new FormatException(complexString);
        string real = complex.Groups["re"].Value;
        double realPart = double.TryParse(real, CultureInfo.InvariantCulture, out double re) ? re : 0;
        string imaginary = complex.Groups["im"].Value;
        if (imaginary == "+" || imaginary == "-") imaginary += "1";
        double imaginaryPart = double.TryParse(imaginary, CultureInfo.InvariantCulture, out double im) ? im : 0;
        return new(realPart, imaginaryPart);
    }

    /// <summary>
    /// Пытается преобразовать строковое представление комплексного числа в объект ComplexNumber.
    /// </summary>
    /// <param name="complexString">Строковое представление комплексного числа.</param>
    /// <param name="complex">Результат преобразования, если успешно, иначе null.</param>
    /// <returns>True, если преобразование выполнено успешно, иначе false.</returns>
    public static bool TryParse(string complexString, out ComplexNumber? complex)
    {
        try
        {
            complex = Parse(complexString);
            return true;
        }
        catch 
        {
            complex = null;
            return false; 
        }
    }

    public override string ToString()
    {
        StringBuilder sb = new();
        if (Real != 0)
        {
            sb.Append(Real.ToString("0.####"));
            if (Imaginary > 0)
                sb.Append('+');
        }
        if (Imaginary != 0)
        {
            if (Imaginary != 1) sb.Append(Imaginary.ToString("0.####"));
            else if (Imaginary == -1) sb.Append('-');
            sb.Append('j');
        }
        if (sb.Length == 0) sb.Append('0');
        return sb.ToString();
    }
        

    [GeneratedRegex("""^(?<re>[+,-]?[0-9]*[,|.]?[0-9]+(?!j))?(?<im>[+,-]?(?:[0-9]*[.|,]?[0-9]+)?(?=j))?j?$""")]
    private static partial Regex Complex();
}