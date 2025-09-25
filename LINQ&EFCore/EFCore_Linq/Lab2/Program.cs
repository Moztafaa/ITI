using System.Collections;
using Dumpify;
namespace Lab2;


public class Program
{

    public static void Main4()
    {
        var numbers = new List<int>() { 2, 4, 6, 7, 1, 4, 2, 9, 1 };

        // 1.1
        IEnumerable<int> res1 = numbers.Distinct().Order();
        // res1.Dump();


        // 1.2
        var res2 = numbers.Order().Distinct().Select(static n => new
        {
            Number = n,
            Multiply = n * n
        });
        // res2.Dump();

        // 2.1
        string[] names = ["Tom", "Dick", "Harry", "MARY", "Jay"];

        IEnumerable<string> res21 = names.Where(static n => n.Length == 3);


        IEnumerable<string> res21Q = from name in names
                                     where name.Length == 3
                                     select name;
        // res21Q.Dump();

        // 2.2
        IEnumerable<string> res22q = from name in names
                                     where name.ToUpper().Contains('A')
                                     orderby name.Length
                                     select name;

        IEnumerable<string> res22 = names.Where(static n => n.ToUpper().Contains('A')).OrderBy(static n => n.Length);
        // res22.Dump();
        // res22q.Dump();

        // 2.3
        IEnumerable<string> res23 = Enumerable.Range(0, 2).Select(n => names[n]);

        IEnumerable<string> res23Q = from i in Enumerable.Range(0, 2)
                                     select names[i];

        // res23Q.Dump();
        // res23.Dump();
        //
        // ------------------------------------------------------

        var students = new List<Studentt>()
        {
            new Studentt()
            {
            ID = 1,
            FirstName = "Ali",
            LastName = "Mohammed",
            subjects = new Subject[]
            {
                new Subject() { Code = 22, Name = "EF" },
                new Subject() { Code = 33, Name = "UML" }
            }
            },
            new Studentt()
            {
            ID = 2,
            FirstName = "Mona",
            LastName = "Gala",
            subjects = new Subject[]
            {
                new Subject() { Code = 22, Name = "EF" },
                new Subject() { Code = 34, Name = "XML" },
                new Subject() { Code = 25, Name = "JS" }
            }
            },
            new Studentt()
            {
            ID = 3,
            FirstName = "Yara",
            LastName = "Yousf",
            subjects = new Subject[]
            {
                new Subject() { Code = 22, Name = "EF" },
                new Subject() { Code = 25, Name = "JS" }
            }
            },
            new Studentt()
            {
            ID = 1,
            FirstName = "Ali",
            LastName = "Ali",
            subjects = new Subject[]
            {
                new Subject() { Code = 33, Name = "UML" }
            }
            }
        };
        // 3.1
        var res31 = students.Select(s => new
        {
            FullName = s.FirstName + " " + s.LastName,
            s.subjects.Length
        });

        // res31.Dump();

        // 3.2
        var res32 = students.OrderByDescending(s => s.FirstName).ThenBy(s => s.LastName).Select(s => new { s.FirstName, s.LastName });

        // 3.3
        var res33 = students.SelectMany(s => s.subjects,
                (student, subject) => new
                {
                    StudentName = student.FirstName + " " + student.LastName,
                    SubjectName = subject.Name
                }
                );


        // 3.4
        // var res34 = students.GroupBy(s)







    }


    public static void Main()
    {

        var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        var names = new List<string> { "Ali", "Omar", "Aya", "Sara", "Ahmed", "Ali" };

        var students = new List<Student>
        {
            new (){ Id=1, Name="Ali", Age=20 },
            new (){ Id=2, Name="Sara", Age=22 },
            new (){ Id=3, Name="Omar", Age=19 },
            new (){ Id=4, Name="Aya", Age=21 },
            new (){ Id=5, Name="Ali", Age=20 }
        };

        // 1
        IEnumerable<int> q1 = numbers.Where(static n => n % 2 == 0);

        // 2
        IEnumerable<Student> q2 = students.Where(static s => s.Age > 20);

        // 3
        IEnumerable<string> q3 = students.Select(static s => s.Name);
        // q3.Dump();


        // 4
        string[] sentences = { "I love C#", "LINQ is powerful" };
        // IEnumerable<string> q4 = sentences.Where(s => s.Split(" ").Concat());
        IEnumerable<string> q4Q = from sentence in sentences
                                  from word in sentence.Split(" ")
                                  select word;


        IEnumerable<string> q4 = sentences.SelectMany(static sentence => sentence.Split(" "));
        // q4.Dump();

        // 5
        IEnumerable<Student> q5 = students.OrderBy(static s => s.Age);

        // 6
        IEnumerable<Student> q6 = students.OrderBy(static s => s.Age).ThenBy(static s => s.Name);

        // 7
        IEnumerable<int> q7 = numbers.Reverse<int>();
        // q7.Dump();

        // 8
        IEnumerable<int> q8 = numbers.Take(5);

        // 9
        IEnumerable<int> q9 = numbers.Skip(3);

        // 10
        IEnumerable<int> q10 = numbers.TakeWhile(static n => n < 6);

        // 11
        IEnumerable<int> q11 = numbers.SkipWhile(static n => n < 6);

        // 12
        int q12 = numbers.First();

        // 13
        int q13 = numbers.Last();

        // 14
        Student q14 = students.Single(static s => s.Id == 2);

        // 15
        int q15 = numbers.Skip(2).First();

        // 16
        IEnumerable<string> q16 = names.Distinct();

        // 17
        IEnumerable<int> l1 = [1, 2, 3], l2 = [3, 4, 5];
        IEnumerable<int> q17 = l1.Union(l2);

        // 18
        IEnumerable<string> q18 = names.Intersect(students.Select(static s => s.Name));

        // 19
        l1 = [1, 2, 3, 4];
        l2 = [3, 4];
        IEnumerable<int> q19 = l1.Except(l2);

        // 20
        IEnumerable<Student> q20 = from student in students
                                   join name in names on student.Name equals name
                                   select student;
        q20.Dump();


        // 21
        var q21 = from name in names
                  join student in students on name equals student.Name into stdGroup
                  select new { Name = name, Students = stdGroup };
        q21.Dump();

        // 22
        IEnumerable<IGrouping<int, Student>> q22 = students.GroupBy(static s => s.Age);

        IEnumerable<IGrouping<int, Student>> q22Q = from student in students
                                                    group student by student.Age;

        // 23
        IEnumerable<IGrouping<char, Student>> q23 = students.GroupBy(static s => s.Name[0]);

        // 24
        int q24 = students.Count(static s => s.Age > 20);

        // 25
        int q25 = numbers.Sum();

        // 26
        double q26 = students.Average(static s => s.Age);

        // 27
        int q27 = students.Min(static s => s.Age);

        // 28
        int q28 = numbers.Take(5).Aggregate(static (acc, n) => acc * n);

        // 29
        bool q29 = students.Any(static s => s.Age > 21);

        // 30
        bool q30 = students.All(static s => s.Age > 18);

        // 31
        bool q31 = names.Contains("Aya");

        // 32
        int[] q32 = numbers.ToArray();

        // 33
        var q33 = students.ToDictionary(static s => s.Id);
        q33.Dump();
        
        var q33Q = students.ToDictionary(static s => s.Id, static s => s.Name);
        q33Q.Dump();

        // 34
        ArrayList mix = [1, "two", 3];

        IEnumerable<int> ints = mix.OfType<int>();

        // ints.Dump();




    }

}


class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}



public class Subject
{
    public int Code { get; set; }
    public string Name { get; set; }
}

public class Studentt
{
    public int ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Subject[] subjects { get; set; }
}


