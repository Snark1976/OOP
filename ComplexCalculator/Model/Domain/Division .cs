namespace ComplexCalculator.Model.Domain;

/// <summary>
/// Класс для операции деления комплексных чисел.
/// </summary>
public class Division : IComplexNumberOperation
{
    /// <summary>
    /// Выполняет операцию деления одного комплексного числа на другое.
    /// </summary>
    /// <param name="num1">Делимое комплексное число.</param>
    /// <param name="num2">Делитель комплексное число.</param>
    /// <returns>Результат деления.</returns>
    public ComplexNumber Execute(ComplexNumber num1, ComplexNumber num2)
    {
        double denominator = num2.Real * num2.Real + num2.Imaginary * num2.Imaginary;
        double realPart = (num1.Real * num2.Real + num1.Imaginary * num2.Imaginary) / denominator;
        double imaginaryPart = (num1.Imaginary * num2.Real - num1.Real * num2.Imaginary) / denominator;
        return new ComplexNumber(realPart, imaginaryPart);
    }
}