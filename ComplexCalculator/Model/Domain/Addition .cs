namespace ComplexCalculator.Model.Domain;

/// <summary>
/// Класс для операции сложения комплексных чисел.
/// </summary>
public class Addition : IComplexNumberOperation
{
    /// <summary>
    /// Выполняет операцию сложения двух комплексных чисел.
    /// </summary>
    /// <param name="num1">Первое комплексное число.</param>
    /// <param name="num2">Второе комплексное число.</param>
    /// <returns>Результат сложения.</returns>
    public ComplexNumber Execute(ComplexNumber num1, ComplexNumber num2)
    {
        return new ComplexNumber(num1.Real + num2.Real, num1.Imaginary + num2.Imaginary);
    }
}
