using ComplexCalculator.Model.Domain;

namespace ComplexCalculator.Controller;

/// <summary>
/// Интерфейс для калькулятора комплексных чисел.
/// </summary>
internal interface IComplexNumberCalculator
{
    /// Складывает два комплексных числа.
    /// </summary>
    /// <param name="num1">Первое комплексное число.</param>
    /// <param name="num2">Второе комплексное число.</param>
    /// <returns>Результат сложения.</returns>
    ComplexNumber Add(ComplexNumber num1, ComplexNumber num2);
    // <summary>
    /// Умножает два комплексных числа.
    /// </summary>
    /// <param name="num1">Первое комплексное число.</param>
    /// <param name="num2">Второе комплексное число.</param>
    /// <returns>Результат умножения.</returns>
    ComplexNumber Multiply(ComplexNumber num1, ComplexNumber num2);
    /// <summary>
    /// Делит одно комплексное число на другое.
    /// </summary>
    /// <param name="num1">Делимое комплексное число.</param>
    /// <param name="num2">Делитель комплексное число.</param>
    /// <returns>Результат деления.</returns>
    ComplexNumber Divide(ComplexNumber num1, ComplexNumber num2);
}
