using ComplexCalculator.Controller;
using ComplexCalculator.Model.Domain;

namespace ComplexCalculator.Model;

/// <summary>
/// Фабрика операций с комплексными числами.
/// </summary>
public class ComplexNumberOperationFactory : IComplexNumberOperationFactory
{
    /// <summary>
    /// Создает операцию с комплексными числами в зависимости от типа операции.
    /// </summary>
    /// <param name="operationType">Тип операции.</param>
    /// <returns>Экземпляр операции.</returns>
    public IComplexNumberOperation CreateOperation(OperationType operationType)
    {
        return operationType switch
        {
            OperationType.Addition => new Addition(),
            OperationType.Multiplication => new Multiplication(),
            OperationType.Division => new Division(),
            _ => throw new ArgumentException("Invalid operation type"),
        };
    }
}
