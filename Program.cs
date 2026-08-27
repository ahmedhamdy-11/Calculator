while (true)
{
    Console.WriteLine("\n=== Calculator ===");

    Console.Write("Enter first number: ");
    if (!double.TryParse(Console.ReadLine(), out double firstNumber))
    {
        Console.WriteLine("Invalid number. Please try again.");
        continue;
    }

    Console.Write("Enter operator (+, -, *, /): ");
    string? operation = Console.ReadLine();

    Console.Write("Enter second number: ");
    if (!double.TryParse(Console.ReadLine(), out double secondNumber))
    {
        Console.WriteLine("Invalid number. Please try again.");
        continue;
    }

    double result;

    switch (operation)
    {
        case "+":
            result = firstNumber + secondNumber;
            break;

        case "-":
            result = firstNumber - secondNumber;
            break;

        case "*":
            result = firstNumber * secondNumber;
            break;

        case "/":
            if (secondNumber == 0)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
                continue;
            }

            result = firstNumber / secondNumber;
            break;

        default:
            Console.WriteLine("Invalid operator.");
            continue;
    }

    Console.WriteLine($"Result: {result}");

    Console.Write("\nDo you want another calculation? (y/n): ");
    string? answer = Console.ReadLine();

    if (answer?.ToLower() != "y")
    {
        Console.WriteLine("Goodbye!");
        break;
    }
}