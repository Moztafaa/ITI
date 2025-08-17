namespace Lec3;

public class Student
{
    public string Name { get; set; } = string.Empty;
    public Dictionary<string, int> Grades { get; set; } = new();
    public List<string> Hobbies { get; set; } = new();

    public Student() { }
    public Student(Student student)
    {
        Name = student.Name;
        Grades = new Dictionary<string, int>(student.Grades);
        Hobbies = new List<string>(student.Hobbies);
    }
}
