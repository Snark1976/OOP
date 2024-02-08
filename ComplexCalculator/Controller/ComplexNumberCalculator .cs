using ComplexCalculator.Model.Domain;
using Microsoft.Extensions.Logging;

namespace ComplexCalculator.Controller;

public class ComplexNumberCalculator(ILogger<ComplexNumberCalculator> logger, IComplexNumberOperationFactory operationFactory) 
    : IComplexNumberCalculator
{
    private readonly ILogger<ComplexNumberCalculator> _logger = logger;
    private readonly IComplexNumberOperationFactory _operationFactory = operationFactory;

    public ComplexNumber Add(ComplexNumber num1, ComplexNumber num2)
    {
        ComplexNumber result = _operationFactory.CreateOperation(OperationType.Addition).Execute(num1, num2);
        _logger.LogInformation("Adding complex numbers: ({num1}) + ({num2}) = ({result})", num1, num2, result);
        return result;
    }

    public ComplexNumber Multiply(ComplexNumber num1, ComplexNumber num2)
    {
        var result = _operationFactory.CreateOperation(OperationType.Multiplication).Execute(num1, num2);
        _logger.LogInformation("Multiplying complex numbers: ({num1}) * ({num2}) = ({result})", num1, num2, result);
        return result;
    }

    public ComplexNumber Divide(ComplexNumber num1, ComplexNumber num2)
    {
        var result = _operationFactory.CreateOperation(OperationType.Division).Execute(num1, num2);
        _logger.LogInformation("Dividing complex numbers: ({num1}) / ({num2}) = ({result})", num1, num2, result);
        return result;
    }
}