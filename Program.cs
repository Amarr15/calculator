while (true)
{
    try
    {
        Console.Write("Enter first number: ");
        double firstNumber = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter operator (+, -, *, /): ");
        string operation = Console.ReadLine();

        Console.Write("Enter second number: ");
        double secondNumber = Convert.ToDouble(Console.ReadLine());

        double result;

        switch (operation)
        {
            case "+":
                result = firstNumber + secondNumber;
                Console.WriteLine($"Result: {result}");
                break;

            case "-":
                result = firstNumber - secondNumber;
                Console.WriteLine($"Result: {result}");
                break;

            case "*":
                result = firstNumber * secondNumber;
                Console.WriteLine($"Result: {result}");
                break;

            case "/":
                if (secondNumber == 0)
                {
                    Console.WriteLine("Cannot divide by zero.");
                }
                else
                {
                    result = firstNumber / secondNumber;
                    Console.WriteLine($"Result: {result}");
                }
                break;

            default:
                Console.WriteLine("Invalid operator.");
                break;
        }
    }
    catch
    {
        Console.WriteLine("Invalid input.");
    }

    Console.Write("\nDo you want to perform another calculation? (y/n): ");

    string answer = Console.ReadLine();

    if (answer != "y")
    {
        break;
    }
}

Console.WriteLine("\nThank you for using the calculator!");