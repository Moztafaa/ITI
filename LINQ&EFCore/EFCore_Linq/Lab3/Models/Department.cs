using System;
using System.Collections.Generic;

namespace Lab3.Models;

public partial class Department
{
    public int DepartmentId { get; set; }

    public string DepartmentName { get; set; } = null!;

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
