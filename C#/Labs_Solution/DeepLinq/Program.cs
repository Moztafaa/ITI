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


using System.Collections;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

// Select<int, int>(null, i => i * 2);

object? o = Enumerable.Range(1, 10);

// if (o is IEnumerable<int> iterate)
// {
//     foreach (var item in iterate)
//     {
//         Console.WriteLine(item);
//     }
// }

IEnumerable<int>? iterate = o as IEnumerable<int>;

foreach (var item in iterate ?? [])
{
    Console.WriteLine(item);
}





static IEnumerable<TResult> Select<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, TResult> selector)
{
    ArgumentNullException.ThrowIfNull(source);
    ArgumentNullException.ThrowIfNull(selector);

    return Impl(source, selector);
    static IEnumerable<TResult> Impl(IEnumerable<TSource> source, Func<TSource, TResult> selector)
    {
        foreach (TSource? item in source)
        {
            yield return selector(item);
        }
    }
}

public sealed class SelectManual<TSource, TResult> : IEnumerable<TResult>
{
    public string? Name { get; set; }
    public IEnumerator<TResult> GetEnumerator() => throw new NotImplementedException();
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

public static partial class Helpers
{
    [GeneratedRegex(@"(?<word>\w+)", RegexOptions.Compiled | RegexOptions.IgnoreCase)]
    public static partial Regex Words();
}
