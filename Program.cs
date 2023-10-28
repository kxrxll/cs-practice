using static Sortings;

Sortings sortings = new Sortings();
int[] array1 = { 1, 22, 44, 78, 5, 3, 18 };
sortings.ShellSorting(array1).ToList().ForEach(i => Console.WriteLine(i.ToString()));
int[] array2 = { 1, 22, 44, 78, 5, 3, 18 };
sortings.BogoSorting(array2).ToList().ForEach(i => Console.WriteLine(i.ToString()));
int[] array3 = { 1, 22, 44, 78, 5, 3, 18 };
sortings.BubbleSort(array3).ToList().ForEach(i => Console.WriteLine(i.ToString()));
