using ComplexCalculator.Model.Domain;

namespace ComplexCalculator.Model;

/// <summary>
/// Интерфейс для операций с комплексными числами.
/// </summary>
public interface IComplexNumberOperation
{
    /// <summary>
    /// Выполняет операцию с двумя комплексными числами.
    /// </summary>
    /// <param name="num1">Первое комплексное число.</param>
    /// <param name="num2">Второе комплексное число.</param>
    /// <returns>Результат операции.</returns>
    ComplexNumber Execute(ComplexNumber num1, ComplexNumber num2);
}
