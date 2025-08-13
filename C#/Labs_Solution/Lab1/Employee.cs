namespace Lab1;

public struct Employee
{
	public int Id;
	private static int AutoId = 0;
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
		System.Console.WriteLine("Enter the number of your employees:");
		var number = Console.ReadLine();
		int.TryParse(number, out int no);
		for (int i = 0; i < no; i++)
		{
			var emp = new Employee();
			// int.TryParse(Console.ReadLine(), out emp.Id);
			emp.Id = ++AutoId;
			System.Console.Write("Enter employee name: ");
			var name = Console.ReadLine();

			if (!string.IsNullOrWhiteSpace(name))
			{
				emp.Name = name;
			}
			else
			{
				System.Console.WriteLine("Name can't be null of empty!");
				break;
			}
			Console.Write("Enter employee salary: ");
			decimal.TryParse(Console.ReadLine(), out emp.Salary);

			// take position form the user 
			Console.Write("Select employee position: 1-Manager, 2-Offcier, 3-Clerk: ");
			int positionInput;
			int.TryParse(Console.ReadLine(), out positionInput);
			emp.EmployeePosition = (Position)positionInput;

			employees.Add(emp);
		}
		return employees;
	}
	public void PrintEmpData()
	{
		System.Console.WriteLine("Employee ID {0}, Name: {1}, Salary: {2}, Position: {3}", Id, Name, Salary, EmployeePosition);
	}

}


