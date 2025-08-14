namespace Lab1;

public struct Employee
{
    public int Id;
    private static int autoId = 0;
    public string Name;
    public decimal Salary;
    public Position EmployeePosition;

    public enum Position
    {
        Manager = 1,
        Officer,
        Clerk,
    }

    public IEnumerable<Employee> Fill_Employee()
    {
        List<Employee> employees = new();
        Console.WriteLine("Enter the number of your employees:");
        string? number = Console.ReadLine();
        int.TryParse(number, out int no);
        for (int i = 0; i < no; i++)
        {
            Employee emp = new Employee
            {
                // int.TryParse(Console.ReadLine(), out emp.Id);
                Id = ++autoId
            };
            Console.Write("Enter employee name: ");
            string? name = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(name))
            {
                emp.Name = name;
            }
            else
            {
                Console.WriteLine("Name can't be null of empty!");
                break;
            }
            Console.Write("Enter employee salary: ");
            decimal.TryParse(Console.ReadLine(), out emp.Salary);

            // take position form the user 
            Console.Write("Select employee position: 1-Manager, 2-Offcier, 3-Clerk: ");
            int.TryParse(Console.ReadLine(), out int positionInput);
            emp.EmployeePosition = (Position) positionInput;

            employees.Add(emp);
        }
        return employees;
    }
    public readonly void PrintEmpData() => Console.WriteLine("Employee ID {0}, Name: {1}, Salary: {2}, Position: {3}", this.Id, this.Name, this.Salary, this.EmployeePosition);

}


