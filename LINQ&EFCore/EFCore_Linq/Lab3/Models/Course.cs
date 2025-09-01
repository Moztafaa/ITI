using System;
using System.Collections.Generic;

namespace Lab3.Models;

public partial class Course
{
    public int CourseId { get; set; }

    public string CourseName { get; set; } = null!;

    public int? Credits { get; set; }

    public int DepartmentId { get; set; }

    public virtual Department Department { get; set; } = null!;

    public virtual ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
}
