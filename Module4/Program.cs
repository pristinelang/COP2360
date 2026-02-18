using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your first number: ");
        string input1 = Console.ReadLine()!;
        Console.Write("Enter your second number: ");
        string input2 = Console.ReadLine()!;

        DivideNumbers(input1, input2);
    }

    static void DivideNumbers(string num1, string num2)
    {
        try
        {
            int number1 = Convert.ToInt32(num1);
            int number2 = Convert.ToInt32(num2);

            int result = number1 / number2;

            Console.WriteLine("Your first number divided by the second number is: " + result);
        }

    catch (FormatException ex)
        {
            Console.WriteLine("Error: Please enter a valid integer.");
            Console.WriteLine($"Detailed error message: {ex.Message}");
        }
    
    catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: You cannot divide by zero.");
            Console.WriteLine($"Detailed error message: {ex.Message}");
        }

    catch (OverflowException ex)
        {
            Console.WriteLine("Error: The number you entered is too large.");
            Console.WriteLine($"Detailed error message: {ex.Message}");
        }

    catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred.");
            Console.WriteLine($"Detailed error message: {ex.Message}");
        }
    Console.WriteLine("Press any key to exit.");
    Console.ReadKey();
}
}