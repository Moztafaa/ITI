using System;
using System.Collections.Generic;

namespace Lab3.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public string StudentName { get; set; } = null!;

    public string? Email { get; set; }

    public int DepartmentId { get; set; }

    public virtual Department Department { get; set; } = null!;

    public virtual ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
}
