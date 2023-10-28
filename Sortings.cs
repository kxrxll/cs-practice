using System.Diagnostics;
public class Sortings
{
    public delegate int[] SortingFunction(int[] array);
    // 2.1 Напишите программу на C# для сортировки списка элементов с помощью сортировки Шелла.
    // - Проведите исследование в интернете: в каких случаях используется сортировка Шелла и как она применяется.
    // - Задайте массив из нескольких элементов
    // - Напишите функцию сортировки Шелла для данного массива 
    // - Модифицируйте программу: добавьте возможность введения элементов в массив.
    public int[] ShellSorting(int[] array)
    {
        int n = array.Length;
        int i, j, step, tmp;
        for (step = n / 2; step > 0; step /= 2)
            for (i = step; i < n; i++)
            {
                tmp = array[i];
                for (j = i; j >= step; j -= step)
                {
                    if (tmp < array[j - step])
                        array[j] = array[j - step];
                    else
                        break;
                }
                array[j] = tmp;
            }
        return array;
    }
    // 2.2 Напишите программу на C# для сортировки списка элементов с помощью сортировки Болотной сортировки.
    // - Проведите исследование в интернете: в каких случаях используется болотная сортировка. Спроектируйте алгоритм
    // - Задайте массив из нескольких элементов 
    // - Напишите функцию болотной сортировки
    // - Модифицируйте программу: добавьте возможность введение элементов в массив
    // - Спроектируйте алгоритм сортировки Шелла. Сравните эффективность сортировки Шелла с болотной. Составьте выводы о скорости работы и предложите улучшение данного алгоритма.
    public int[] BogoSorting(int[] array)
    {
        int iteration = 0;
        while (!IsSorted(array))
        {
            array = Shuffle(array);
            iteration++;
        }
        return array;

        bool IsSorted(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    return false;
                }
            }

            return true;
        }

        int[] Shuffle(int[] array)
        {
            Random r = new Random();
            for (int n = array.Length - 1; n > 0; --n)
            {
                int k = r.Next(n + 1);
                int temp = array[n];
                array[n] = array[k];
                array[k] = temp;
            }
            return array;
        }
    }
    //     2.3 Напишите программу на C# для сортировки списка элементов с помощью сортировки пузырьком.
    // - Проведите исследование в интернете: в каких случаях используется сортировка пузырьком и как она применяется.
    // - Задайте массив из нескольких элементов
    // - Напишите функцию сортировки пузырьком для данного массива 
    // - Модифицируйте программу: добавьте возможность введения элементов в массив.
    public int[] BubbleSorting(int[] array)
    {
        int temp = 0;
        for (int write = 0; write < array.Length; write++)
        {
            for (int sort = 0; sort < array.Length - 1; sort++)
            {
                if (array[sort] > array[sort + 1])
                {
                    temp = array[sort + 1];
                    array[sort + 1] = array[sort];
                    array[sort] = temp;
                }
            }
        }
        return array;
    }
    //     2.4 Напишите программу на C# для сортировки списка элементов с помощью сортировки слиянием.
    // - Проведите исследование в интернете: в каких случаях используется сортировка слиянием и как она применяется.
    // - Задайте массив из нескольких элементов
    // - Напишите функцию сортировки слиянием для данного массива 
    // - Модифицируйте программу: добавьте возможность введения элементов в массив.

    public int[] MergeSorting(int[] array)
    {
        int[] MergeSortingWithBorders(int[] array, int lowIndex, int highIndex)
        {
            void Merge(int[] array, int lowIndex, int middleIndex, int highIndex)
            {
                int left = lowIndex;
                int right = middleIndex + 1;
                int[] tempArray = new int[highIndex - lowIndex + 1];
                int index = 0;
                while ((left <= middleIndex) && (right <= highIndex))
                {
                    if (array[left] < array[right])
                    {
                        tempArray[index] = array[left];
                        left++;
                    }
                    else
                    {
                        tempArray[index] = array[right];
                        right++;
                    }

                    index++;
                }
                for (int i = left; i <= middleIndex; i++)
                {
                    tempArray[index] = array[i];
                    index++;
                }
                for (int i = right; i <= highIndex; i++)
                {
                    tempArray[index] = array[i];
                    index++;
                }

                for (int i = 0; i < tempArray.Length; i++)
                {
                    array[lowIndex + i] = tempArray[i];
                }
            }
            if (lowIndex < highIndex)
            {
                var middleIndex = (lowIndex + highIndex) / 2;
                MergeSortingWithBorders(array, lowIndex, middleIndex);
                MergeSortingWithBorders(array, middleIndex + 1, highIndex);
                Merge(array, lowIndex, middleIndex, highIndex);
            }
            return array;
        }
        return MergeSortingWithBorders(array, 0, array.Length - 1);
    }
    //     2.5 Напишите программу на C# для сортировки списка элементов с помощью сортировки выбором.
    // - Проведите исследование в интернете: в каких случаях используется сортировка выбором и как она применяется.
    // - На основе пункта 1.3 модифицируйте алгоритм таким образом, чтобы осуществлялась сортировка выбором
    // - 1.7 Составьте карту времени работы алгоритма для массивов из 5/10/50/100 элементов. 
    // - Запустите все сортировки, зафиксируйте время исполнения алгоритмов для каждого кол-ва элементов в массиве. 
    // - Составьте диаграмму, наглядно показывающую время работы алгоритмов. 
    public int[] SelectionSorting(int[] array)
    {
        void Swap(ref int x, ref int y)
        {
            int t = x;
            x = y;
            y = t;
        }

        int IndexOfMin(int[] array, int n)
        {
            int result = n;
            for (int i = n; i < array.Length; ++i)
            {
                if (array[i] < array[result])
                {
                    result = i;
                }
            }

            return result;
        }
        int currentIndex = 0;
        while (currentIndex != array.Length)
        {
            int index = IndexOfMin(array, currentIndex);
            if (index != currentIndex)
            {
                Swap(ref array[index], ref array[currentIndex]);
            }
            currentIndex += 1;
        }
        return array;
    }
    // Вспомогательные функции для исследований.
    public void ReadFromConsole()
    {
        Console.WriteLine("Сортировка массива и использованием разных алгоритмов.");
        Console.Write("Введите элементы массива: ");
        string? r = Console.ReadLine();
        string[] s = new string[0];
        if (r != null)
        {
            s = r.Split(new[] { " ", ",", ";" }, StringSplitOptions.RemoveEmptyEntries);
        }
        int[] a = new int[s.Length];
        for (int i = 0; i < s.Length; i++)
        {
            a[i] = Convert.ToInt32(s[i]);
        }
        int[] clonedArray = (int[])a.Clone();
        long resultingArray = timeCheck(clonedArray, ShellSorting);
        Console.WriteLine("Упорядоченный массив: {0}", string.Join(", ", clonedArray));
        Console.WriteLine("Время потраченное на сортировку Шелла: {0}", resultingArray);
        clonedArray = (int[])a.Clone();
        Console.WriteLine("Время потраченное на болотную сортировку: {0}", timeCheck(clonedArray, BogoSorting));
        clonedArray = (int[])a.Clone();
        Console.WriteLine("Время потраченное на сортировку пузырьком: {0}", timeCheck(clonedArray, BubbleSorting));
        clonedArray = (int[])a.Clone();
        Console.WriteLine("Время потраченное на сортировку сляиянием: {0}", timeCheck(clonedArray, MergeSorting));
        clonedArray = (int[])a.Clone();
        Console.WriteLine("Время потраченное на сортировку выбором: {0}", timeCheck(clonedArray, SelectionSorting));
        Console.WriteLine("Нажмите любую кнопку для выхода");
        Console.ReadLine();
    }
    public long timeCheck(int[] a, SortingFunction function)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        function(a);
        stopwatch.Stop();
        return stopwatch.ElapsedMilliseconds;
    }
}


