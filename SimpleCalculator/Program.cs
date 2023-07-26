using SimpleCalculator.Enums;
using SimpleCalculator.Interfaces;
using SimpleCalculator.Services;

ICalculatorService calculatorService = new CalculatorService();

Console.WriteLine($"{CalculationsType.A} - Addition");
Console.WriteLine($"{CalculationsType.S} - Subtraction");
Console.WriteLine($"{CalculationsType.M} - Multiplication"); 
Console.WriteLine($"{CalculationsType.D} - Division");

var mathOperation = Console.ReadLine().ToUpper();

if ( mathOperation == "A" || mathOperation == "S" || mathOperation == "M" || mathOperation == "D")
{
    switch (Enum.Parse(typeof(CalculationsType), mathOperation))
    {
        case CalculationsType.A:
            calculatorService.Addition();
            break;

        case CalculationsType.S:
            calculatorService.Subtraction();
            break;

        case CalculationsType.M:
            calculatorService.Multiplication();
            break;

        case CalculationsType.D:
            calculatorService.Division();
            break;

        default:
            break;
    }
}
else
{
    Console.WriteLine("Invalid option");
}

