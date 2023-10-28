public class Sortings
{
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
    public int[] BubbleSort(int[] array)
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

}

