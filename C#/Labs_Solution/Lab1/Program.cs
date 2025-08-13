using Lab1;
using Spectre.Console;

/*
1)	Fill_employee data that takes employee data from user and  return struct 
2)	Print employee data that prints the employee data 
3)	Ask the user for how many employee he has ? 
4)	Use the functions for array of employee  
*/

IEnumerable<int> tes = [1, 3, 3];

var employee = new Employee();
var employees = employee.Fill_Employee();

foreach (var emp in employees)
{
  emp.PrintEmpData();

}

