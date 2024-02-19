using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Simple Calculator");

        while (true)
        {
            Console.WriteLine("Enter an operation (+, -, *, /) or 'q' to quit:");
            string operation = Console.ReadLine();

            if (operation == "q")
                break;

            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                        Console.WriteLine("Error: Cannot divide by zero!");
                    break;
                default:
                    Console.WriteLine("Invalid operation!");
                    break;
            }

            Console.WriteLine($"Result: {result}\n");
        }

        Console.WriteLine("Calculator has been closed. Press any key to exit...");
        Console.ReadKey();
    }
}

