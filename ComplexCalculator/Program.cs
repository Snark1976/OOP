using ComplexCalculator.Controller;
using ComplexCalculator.Model;
using ComplexCalculator.Model.Domain;
using Microsoft.Extensions.Logging;

class Program
{
    static void Main(string[] args)
    {
        using ILoggerFactory loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());
        ILogger<ComplexNumberCalculator> logger = loggerFactory.CreateLogger<ComplexNumberCalculator>();
        ComplexNumberOperationFactory operationFactory = new();
        var calculator = new ComplexNumberCalculator(logger, operationFactory);

        string complexString1 = "3+2j";
        string complexString2 = "1-4j";

        ComplexNumber num1 = ComplexNumber.Parse(complexString1);
        ComplexNumber num2 = ComplexNumber.Parse(complexString2);

        ComplexNumber sum = calculator.Add(num1, num2);
        ComplexNumber product = calculator.Multiply(num1, num2);
        ComplexNumber quotient = calculator.Divide(num1, num2);

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Product: {product}");
        Console.WriteLine($"Quotient: {quotient}");
    }
}
