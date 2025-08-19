using System.Numerics;
using System.Reflection;
// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using Dumpify;
using Lab2_sol;


internal static class Program
{
    private static void Main(string[] args)
    {
        var Employee = new Employee();
        #region Calculate
        int Calculate(in int num1, in int num2, out int mult)
        {
            mult = num1 * num2;
            Console.WriteLine($"The Multiplication of two numbers is {mult}");
            return num1 + num2;
        }

        Console.WriteLine("Enter number 1: ");
        var input1 = Console.ReadLine();
        while (string.IsNullOrEmpty(input1) || !int.TryParse(input1, out _))
        {
            Console.WriteLine("Input cannot be empty and must be a valid number.");
            input1 = Console.ReadLine();
        }

        var num1 = int.Parse(input1);
        Console.WriteLine("Enter number 2: ");
        var input2 = Console.ReadLine();
        while (string.IsNullOrEmpty(input2) || !int.TryParse(input2, out _))
        {
            Console.WriteLine("Input cannot be empty and must be a valid number.");
            input2 = Console.ReadLine();
        }

        var num2 = int.Parse(input2);
        var res = Calculate(num1, num2, out var _);
        Console.WriteLine($"The Sum of two numbers is {res}");
        #endregion

        ///////////////////////////////////////////// Task 2 /////////////////////////////////////////////
        #region Employee

        Employee emp = new();
        Fill_Data(emp);
        Print_Data(emp);

        void Fill_Data(Employee emp)
        {
            Console.Write("Enter the Employee ID: ");
            var id = Console.ReadLine();
            while (string.IsNullOrEmpty(id) || !int.TryParse(id, out var _))
            {
                Console.WriteLine("ID cannot be empty and must be a valid number.");
                id = Console.ReadLine();
            }

            emp.Id = int.Parse(id);

            Console.Write("Enter the Employee Name: ");
            var name = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Name cannot be empty or whitespace.");
                name = Console.ReadLine();
            }

            emp.Name = name;

            Console.Write("Enter the Employee Salary: ");
            var salary = Console.ReadLine();
            while (string.IsNullOrEmpty(salary) || !float.TryParse(salary, out var empSalary) || empSalary <= 0)
            {
                Console.WriteLine("Salary cannot be empty and must be a valid number.");
                salary = Console.ReadLine();
            }

            emp.Salary = float.Parse(salary);
        }

        void Print_Data(Employee emp) => emp.Dump("Employee Details");
        #endregion




        // Application app = new();
        // var appName = app.GetType().GetProperty(nameof(Application.Name), BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly)!.GetValue(app);
        // System.Console.WriteLine(appName);
        // app.Name = "Mostafa";
        // System.Console.WriteLine(app.Name);
        // var.MyProperty = 1;

    }
}


// public class Application
// {
//     public string NewName { get; set; } = "AnalyzerApp";

//     public string? Name
//     {
//         get;
//         set
//         {
//             field = value;
//             field += "hh";
//             NewName = field;
//         }
//     }
// }

// public static class var
// {
//     public static int MyProperty { get; set; }
// }