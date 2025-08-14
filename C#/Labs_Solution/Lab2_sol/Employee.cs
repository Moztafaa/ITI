using System;

namespace Lab2_sol;


public class Employee : IEmployee
{

    public Employee() { }
    public Employee(int id, string? name, float salary)
    {
        Id = id; Name = name; Salary = salary;
    }

    public int Years { get; set; }
    public int Id { get; set; }
    public string? Name { get; set; }
    public float Salary { get; set; }
}

