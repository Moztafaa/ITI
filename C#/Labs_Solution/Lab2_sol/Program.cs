using Lab2_sol;
using Dumpify;

int calculate(in int num1, in int num2, out int mult)
{
    mult = num1 * num2;
    Console.WriteLine($"The Multiplication of two numbers is {mult}");
    return num1 + num2;
}

IEmployee emp1 = new Employee();

Console.WriteLine("Enter number 1: ");
string? input1 = Console.ReadLine();
while (string.IsNullOrEmpty(input1) || !int.TryParse(input1, out int number1))
{
    Console.WriteLine("Input cannot be empty and must be a valid number.");
    input1 = Console.ReadLine();
}
int num1 = int.Parse(input1);
Console.WriteLine("Enter number 2: ");
string? input2 = Console.ReadLine();
while (string.IsNullOrEmpty(input2) || !int.TryParse(input2, out int number2))
{
    Console.WriteLine("Input cannot be empty and must be a valid number.");
    input2 = Console.ReadLine();
}
int num2 = int.Parse(input2);
int res = calculate(num1, num2, out int mult);
Console.WriteLine($"The Sum of two numbers is {res}");

///////////////////////////////////////////// Task 2 /////////////////////////////////////////////


Employee emp = new Employee();
fill_Data(emp);
print_Data(emp);


void fill_Data(Employee emp)
{
    Console.Write("Enter the Employee ID: ");
    string? id = Console.ReadLine();
    while (string.IsNullOrEmpty(id) || !int.TryParse(id, out int empId))
    {
        Console.WriteLine("ID cannot be empty and must be a valid number.");
        id = Console.ReadLine();
    }
    emp.Id = int.Parse(id);


    Console.Write("Enter the Employee Name: ");
    string? name = Console.ReadLine();
    while (string.IsNullOrWhiteSpace(name))
    {
        Console.WriteLine("Name cannot be empty or whitespace.");
        name = Console.ReadLine();
    }
    emp.Name = name;

    Console.Write("Enter the Employee Salary: ");
    string? salary = Console.ReadLine();
    while (string.IsNullOrEmpty(salary) || !float.TryParse(salary, out float empSalary) || empSalary <= 0)
    {
        Console.WriteLine("Salary cannot be empty and must be a valid number.");
        salary = Console.ReadLine();
    }
    emp.Salary = float.Parse(salary);

}

void print_Data(Employee emp) => emp.Dump("Employee Details");


