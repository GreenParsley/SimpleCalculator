using SimpleCalculator.Interfaces;

namespace SimpleCalculator.Services;

public class CalculatorService : ICalculatorService
{
    public void Addition()
    {
        var numbers = UserInputNumbers();
        var result = numbers[0] + numbers[1];
        Console.WriteLine($"The result of the addition is {result}.");
    }

    public void Division()
    {
        var numbers = UserInputNumbers();
        var result = (double)numbers[0] / (double)numbers[1];
        Console.WriteLine($"The result of the division is {result}.");
    }

    public void Multiplication()
    {
        var numbers = UserInputNumbers();
        var result = numbers[0] * numbers[1];
        Console.WriteLine($"The result of the multiplication is {result}.");
    }

    public void Subtraction()
    {
        var numbers = UserInputNumbers();
        var result = numbers[0] - numbers[1];
        Console.WriteLine($"The result of the subtraction is {result}.");
    }

    private List<int> UserInputNumbers()
    {
        Console.WriteLine("Please enter the first number.");
        var firstString = Console.ReadLine();
        var finalNumber = new List<int>();

        if (int.TryParse(firstString, out int firstInt))
        {
            finalNumber.Add(firstInt);
        }
        else
        {
            Console.WriteLine("Invalid input. Number will default to 1.");
            finalNumber.Add(1);
        } 
        
        Console.WriteLine("Please enter the second number.");
        var secondString = Console.ReadLine();

        if (int.TryParse(secondString, out int secondInt))
        {
            finalNumber.Add(secondInt);
        }
        else
        {
            Console.WriteLine("Invalid input. Number will default to 1.");
            finalNumber.Add(1);
        }
        return finalNumber;
    }
}
