// Task “Smart Calculator”

// Use delegation to do Arithmetic Operations : Add , Multiply , Subtract , Division
// Use Exception Handling to send messages for some exceptions : e.g. divided by zero , Multiply use over flow exception  , ..etc.





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
        Calculator(Add, a, b);
        break;
    case 2:
        Calculator(Subtract, a, b);
        break;
    case 3:
        Calculator(Multiply, a, b);
        break;
    case 4:
        Calculator(Divide, a, b);
        break;
    default:
        Console.WriteLine("Invalid operation selected.");
        break;
}




static double Add(double a, double b) => a + b;
static double Subtract(double a, double b) => a - b;
static double Multiply(double a, double b) => a * b;
static double Divide(double a, double b)
{
    if (b == 0)
    {
        throw new DivideByZeroException();
    }
    else
    {
        return a / b;
    }
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