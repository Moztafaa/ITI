// IEnumerable<int> e = GetValues();

// using IEnumerator<int> enumerator = e.GetEnumerator();

// try
// {
//     while (enumerator.MoveNext())
//     {
//         int i = enumerator.Current;
//         System.Console.WriteLine(i);

//     }
// }
// finally
// {
//     enumerator?.Dispose();
// }

// foreach (int i in GetValues())
// {
//     System.Console.WriteLine(i);
// }

// static IEnumerable<int> GetValues()
// {
//     yield return 1;
//     yield return 2;
//     yield return 3;
// }



// IEnumerable<int> source = new[] { 1, 3, 4, 5, 6 };
// foreach (var i in Select(source, i => i * 2))
// {
//     System.Console.WriteLine(i);
// }

// Select<int, int>(null, i => i * 2);

// object? o = Enumerable.Range(1, 10);

// if (o is IEnumerable<int> iterate)
// {
//     foreach (var item in iterate)
//     {
//         Console.WriteLine(item);
//     }
// }

// IEnumerable<int>? iterate = o as IEnumerable<int>;

// foreach (var item in iterate ?? [])
// {
//     Console.WriteLine(item);
// }





// static IEnumerable<TResult> Select<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, TResult> selector)
// {
//     ArgumentNullException.ThrowIfNull(source);
//     ArgumentNullException.ThrowIfNull(selector);

//     return Impl(source, selector);
//     static IEnumerable<TResult> Impl(IEnumerable<TSource> source, Func<TSource, TResult> selector)
//     {
//         foreach (TSource? item in source)
//         {
//             yield return selector(item);
//         }
//     }
// }

// public sealed class SelectManual<TSource, TResult> : IEnumerable<TResult>
// {
//     public string? Name { get; set; }
//     public IEnumerator<TResult> GetEnumerator() => throw new NotImplementedException();
//     IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
// }

// public static partial class Helpers
// {
//     [GeneratedRegex(@"(?<word>\w+)", RegexOptions.Compiled | RegexOptions.IgnoreCase)]
//     public static partial Regex Words();
// }


Shape shape = new Circle(5);

double area = shape switch
{
    Circle c => Math.PI * c.Radius * c.Radius,
    Rectangle r => r.Width * r.Height,
    Triangle t => 0.5 * t.Base * t.Height,
    _ => throw new NotImplementedException()
};


System.Console.WriteLine($"Area: {area}");

var nums = new List<int> { 1, 2, 3, 4, 5 };

PrintThese(nums);

static void PrintThese(params List<int> numbers)
{
    foreach (int number in numbers)
    {
        System.Console.WriteLine(number);
    }
}





public abstract record Shape;
public record Circle(double Radius) : Shape;
public record Rectangle(double Width, double Height) : Shape;
public record Triangle(double Base, double Height) : Shape;


// public union Shape
// {
//     case Circle(double Radius);
//     case Rectangle(double Width, double Height);
//     case Triangle(double Base, double Height);
// }


