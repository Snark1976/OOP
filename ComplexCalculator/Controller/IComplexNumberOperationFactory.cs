using ComplexCalculator.Model;

namespace ComplexCalculator.Controller;

/// <summary>
/// Интерфейс для фабрики операций.
/// </summary>
public interface IComplexNumberOperationFactory
{
    /// <summary>
    /// Создает операцию с комплексными числами в зависимости от типа операции.
    /// </summary>
    /// <param name="operationType">Тип операции.</param>
    /// <returns>Экземпляр операции.</returns>
    IComplexNumberOperation CreateOperation(OperationType operationType);
}