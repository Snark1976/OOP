namespace ComplexCalculator.Model.Domain;

/// <summary>
/// Класс для операции умножения комплексных чисел.
/// </summary>
public class Multiplication : IComplexNumberOperation
{
    /// <summary>
    /// Выполняет операцию умножения двух комплексных чисел.
    /// </summary>
    /// <param name="num1">Первое комплексное число.</param>
    /// <param name="num2">Второе комплексное число.</param>
    /// <returns>Результат умножения.</returns>
    public ComplexNumber Execute(ComplexNumber num1, ComplexNumber num2)
    {
        return new ComplexNumber(
            num1.Real * num2.Real - num1.Imaginary * num2.Imaginary,
            num1.Real * num2.Imaginary + num1.Imaginary * num2.Real);
    }
}
