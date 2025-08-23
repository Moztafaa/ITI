


// use the event
using Lab5;
using System;

// use the event
WeatherEvent weatherEvent = new WeatherEvent();
WeatherEvent.WeatherHandler handler = message => Console.WriteLine(message);
weatherEvent.WeatherChanged += handler;
Console.Write("Enter temperature in Celsius: ");
var input = Console.ReadLine();
if (int.TryParse(input, out var celsius))
{
    weatherEvent.CheckTemperature(celsius);
}
else
{
    Console.WriteLine("Invalid input. Please enter a valid integer for Celsius temperature.");
}



/*
double a, b;
int op;

while (true)
{
    Console.Write("Enter First Number: ");
    var num1 = Console.ReadLine();
    Console.Write("Enter Second Number: ");
    var num2 = Console.ReadLine();

    if (!double.TryParse(num1, out a) || !double.TryParse(num2, out b))
    {
        Console.WriteLine("Invalid input. Please enter valid numbers.");
        continue;
    }

    Console.WriteLine("Select an operation: 1. Add 2. Subtract 3. Multiply 4. Divide");
    var operation = Console.ReadLine();

    if (!int.TryParse(operation, out op) || op < 1 || op > 4)
    {
        Console.WriteLine("Invalid operation selected. Please select a valid operation.");
        continue;
    }

    break;
}

switch (op)
{
    case 1:
        Calculator((double a, double b) => a + b, a, b);
        break;
    case 2:
        Calculator((double a, double b) => a - b, a, b);
        break;
    case 3:
        Calculator((double a, double b) => a * b, a, b);
        break;
    case 4:
        Calculator((double a, double b) => b == 0 ? throw new DivideByZeroException() : a / b, a, b);
        break;
    default:
        Console.WriteLine("Invalid operation selected.");
        break;
}


static void Calculator(Func<double, double, double> operation, double a, double b)
{
    try
    {
        double result = operation(a, b);
        Console.WriteLine($"Result: {result}");
    }
    catch (DivideByZeroException)
    {

        Console.WriteLine("Error: Division by zero is not allowed.");
    }
    catch (OverflowException)
    {
        Console.WriteLine("Error: Arithmetic operation resulted in an overflow.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"An unexpected error occurred: {ex.Message}");
    }
}



*/
