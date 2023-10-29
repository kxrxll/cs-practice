using static Sortings;
using static Files;
using static Recursive;

// Sortings sortings = new Sortings();
// sortings.StartSorting();
// Files files = new Files();
// files.CreateFile();
Recursive recursive = new Recursive();
Console.WriteLine(recursive.IntArray(10));
recursive = new Recursive();
Console.WriteLine(recursive.IntArrayReverse(10));
recursive = new Recursive();
Console.WriteLine(recursive.IntArraySum(10));
recursive = new Recursive();
Console.WriteLine(recursive.Fibonacci(10));
Console.WriteLine(recursive.Power(5, 3));