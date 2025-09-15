using System.Collections;
using Dumpify;
namespace Lec3;

internal static class ClassRoom
{
    private static void Main(string[] args)
    {
        List<Student> students = new(3)
        {
            new Student
            {
                Name = "Ahmed",
                Grades = new Dictionary<string, int>
                {
                    { "Math", 90 },
                    { "Science", 85 },
                    { "English", 88 },
                    { "History", 92 }
                },
                Hobbies = new List<string> { "Reading", "Football", "Coding" }
            },
                new Student
            {
                Name = "Sara",
                    Grades = new Dictionary<string, int>
                {
                    { "Math", 95 },
                    { "Science", 89 },
                    { "English", 91 },
                        { "History", 87 }
                },
                Hobbies = new List<string> { "Painting", "Swimming", "Reading" }
            },
            new Student
            {
                Name = "Omar",
                Grades = new Dictionary<string, int>
                {
                    { "Math", 78 },
                    { "Science", 82 },
                    { "English", 80 },
                    { "History", 75 }
                },
                Hobbies = new List<string> { "Gaming", "Cycling", "Music" }
            }
        };

        // Task 1
        foreach (Student student in students)
        {
            double avg = student.Grades.Values.Average();

            System.Console.WriteLine("{0} has an average grade of {1}", student.Name, avg);
        }

        IEnumerable<string> subjects = students.SelectMany(s => s.Grades.Keys).Distinct();
        foreach (string subject in subjects)
        {
            System.Console.WriteLine("Average grade for {0} is:", subject);
            var avg = students
                        .Where(s => s.Grades.ContainsKey(subject))
                        .Average(s => s.Grades[subject]);
            System.Console.WriteLine("{0} has an average grade of {1}", subject, avg);
        }


        List<Student> students1 = students.Select(s => new Student(s)).ToList();

        // Task 2
        System.Console.WriteLine("\n____ Task 2: ____");
        foreach (Student student in students1)
        {
            student.Grades.Clear();
        }
        foreach (Student student in students1)
        {
            System.Console.Write("Enter the total number of subjects for {0}: ", student.Name);
            var nRead = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(nRead) || !int.TryParse(nRead, out _))
            {
                System.Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }
            _ = int.TryParse(nRead, out var n);
            for (int i = 0; i < n; i++)
            {
                System.Console.Write("Enter subject name: ");
                string? subjectName = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(subjectName))
                {
                    System.Console.WriteLine("Subject name cannot be empty.");
                    continue;
                }

                Console.Write("Enter Grade for subject {0}: ", subjectName);
                var gradeString = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(gradeString) || !int.TryParse(gradeString, out _))
                {
                    System.Console.WriteLine("Invalid grade input. Please enter a valid number.");
                    continue;
                }
                _ = int.TryParse(gradeString, out var grade);
                if (!string.IsNullOrWhiteSpace(subjectName))
                {
                    student.Grades[subjectName] = grade;
                }
                else
                {
                    System.Console.WriteLine("Subject is empty");
                }
            }
            student.Dump();

        }





        // Task 3
        System.Console.WriteLine("\n____ Task 3: ____");
        foreach (Student student in students)
        {
            System.Console.WriteLine("Enter a new hobby for {0}:", student.Name);
            string? hobby = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(hobby))
            {
                student.Hobbies.Add(hobby);
            }
            else
            {
                System.Console.WriteLine("Hobby cannot be empty.");
            }
            student.Dump("Student Details for " + student.Name);
        }
    }
}
