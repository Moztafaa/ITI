using Lab1;

/*
1)	Fill_employee data that takes employee data from user and  return struct 
2)	Print employee data that prints the employee data 
3)	Ask the user for how many employee he has ? 
4)	Use the functions for array of employee  
*/

IEnumerable<int> tes = [1, 3, 3];


Employee employee = new Employee();
IEnumerable<Employee> employees = employee.Fill_Employee();

foreach (Employee emp in employees)
{
    emp.PrintEmpData();

}

