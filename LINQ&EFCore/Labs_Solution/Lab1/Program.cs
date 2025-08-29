using Dumpify;

namespace Lab1;

class Program
{
    static void Main(string[] args)
    {
        IEnumerable<Person> list = Data.People;
        IEnumerable<int> nums = Data.Numbers;
        // 1
        IEnumerable<string> res1Q = from person in list
                                    where person.Age >= 10
                                    select person.Name;

        IEnumerable<string> res1 = list.Where(p => p.Age >= 30).Select(p => p.Name);

        // 2
        IEnumerable<Person> res2Q = from person in list
                                    where person.City == "Cairo" && person.Salary > 25000 && person.Salary < 35000
                                    select person;

        IEnumerable<Person> res2 = list.Where(person => person.City == "Cairo" && person.Salary > 25000 && person.Salary < 35000);

        //3
        IEnumerable<string> res3Q = from p in list
                                    select p.Name.ToUpper();
        IEnumerable<string> res3 = list.Select(p => p.Name.ToUpper());

        // 4
        var res4Q = from p in list
                    select new
                    {
                        p.Name,
                        TenureYears = (DateTime.Now - p.HireDate).TotalDays / 365.25
                    };

        var res4 = list.Select(
            static p => new
            {
                p.Name,
                TenureYears = (DateTime.Now - p.HireDate).TotalDays / 365.25
            }
        );

        // 5
        IEnumerable<Person> res5Q = from p in list
                                    orderby p.Age, p.Name
                                    select p;

        IEnumerable<Person> res5 = list.OrderByDescending(p => p.Age)
                        .ThenBy(p => p.Name);

        // 6

        IEnumerable<Person> res6Q = from p in list
                                    orderby p.Salary descending, p.HireDate
                                    select p;

        IEnumerable<Person> res6 = list.OrderByDescending(p => p.Salary).ThenBy(p => p.HireDate);

        // 7
        var res7Q = (from p in list
                     orderby p.Salary descending
                     select new { p.Name, p.Salary }).Take(3);

        var res7 = list.OrderByDescending(p => p.Salary).Select(p => new { p.Name, p.Salary }).Take(3);


        // 8 
        IEnumerable<Person> res8Q = (from p in list
                                     orderby p.Age
                                     select p).Skip(2).Take(5);

        IEnumerable<Person> res8 = list.OrderBy(p => p.Age).Skip(2).Take(5);

        // 9
        int pageSize = 3, pageNumber = 2;
        IEnumerable<Person> res9 = list.OrderBy(p => p.Name)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize);

        // 10
        IEnumerable<int> res10 = nums.Order().TakeWhile(n => n < 10);

        // 11
        IEnumerable<int> res11 = nums.Order().SkipWhile(n => n < 10);


        // 12
        var res12 = list.Where(p => p.City == "Cairo" && p.Age >= 28)
            .OrderByDescending(p => p.HireDate)
            .Select(p => new
            {
                p.Name,
                TenureYears = (DateTime.Now - p.HireDate).TotalDays / 365.25
            })
            .Take(3);



        string s = null;
        System.Console.WriteLine(s);
    }
}



public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string City { get; set; }
    public decimal Salary { get; set; }
    public DateTime HireDate { get; set; }

    public Person(string name, int age, string city, decimal salary, DateTime hireDate)
    {
        Name = name;
        Age = age;
        City = city;
        Salary = salary;
        HireDate = hireDate;
    }
}
public static class Data
{
    public static List<Person> People = new()
    {
        new("Aya", 28, "Cairo", 22000m, new DateTime(2022, 6, 1)),
        new("Karim", 35, "Giza", 31000m, new DateTime(2019, 11, 15)),
        new("Nour", 31, "Alexandria", 28000m, new DateTime(2021, 2, 5)),
        new("Hassan", 24, "Cairo", 18000m, new DateTime(2024, 3, 12)),
        new("Mona", 29, "Cairo", 26000m, new DateTime(2020, 7, 30)),
        new("Omar", 41, "Giza", 45000m, new DateTime(2016, 1, 10)),
        new("Sarah", 33, "Cairo", 33000m, new DateTime(2018, 9, 20)),
        new("Youssef", 27, "Alexandria", 21000m, new DateTime(2023, 5, 8)),
        new("Dina", 36, "Cairo", 38000m, new DateTime(2017, 12, 1)),
        new("Mahmoud",    30, "Giza", 30000m, new DateTime(2020, 4, 18)),
    };

    public static int[] Numbers = new[] { 3, 6, 9, 12, 15, 2, 4, 8, 16, 1, 5, 7, 10, 14, 18, 20 };
}
