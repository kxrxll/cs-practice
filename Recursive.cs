using static Sortings;

using System.Diagnostics.Metrics;

public class Recursive
{
    public int[] arrayToPrint = { };
    Sortings sortings = new Sortings();
    // 3.1 Напишите программу на языке C# для печати всех n натуральных чисел с использованием рекурсии. 
    // Входные данные :
    // Сколько чисел нужно напечатать : 10 
    // Ожидаемый результат : 1 2 3 4 5 6 7 8 9 10 
    public string IntArray(int x)
    {
        if (x == 0)
        {
            return string.Join(", ", sortings.MergeSorting(arrayToPrint));
        }
        Array.Resize(ref arrayToPrint, arrayToPrint.Length + 1);
        arrayToPrint[arrayToPrint.GetUpperBound(0)] = x;
        return IntArray(x - 1);
    }
    // 3.2 Напишите программу на языке C# для печати чисел от n до 1 с использованием рекурсии. 
    // Входные данные :
    // Сколько чисел нужно напечатать : 10 
    // Ожидаемый результат : 10 9 8 7 6 5 4 3 2 1
    public string IntArrayReverse(int x)
    {
        if (x == 0)
        {
            return string.Join(", ", arrayToPrint);
        }
        Array.Resize(ref arrayToPrint, arrayToPrint.Length + 1);
        arrayToPrint[arrayToPrint.GetUpperBound(0)] = x;
        return IntArrayReverse(x - 1);
    }
    // 3.3 Напишите программу на языке C# для нахождения суммы первых n натуральных чисел с помощью рекурсии. 
    // Входные данные :
    // Сколько чисел нужно сложить : 10 
    // Ожидаемый результат : 55 
    public int IntArraySum(int x)
    {
        if (x == 0)
        {
            return arrayToPrint.Sum();
        }
        Array.Resize(ref arrayToPrint, arrayToPrint.Length + 1);
        arrayToPrint[arrayToPrint.GetUpperBound(0)] = x;
        return IntArraySum(x - 1);
    }
    // 3.4 Напишите программу на языке C# для нахождения чисел Фибоначчи для n чисел серий с использованием рекурсии. 
    // Входные данные :
    // Входное количество членов для ряда Фибоначчи : 10 
    // Ожидаемый результат : 0 1 1 2 3 5 8 13 21 34 
    public int Fibonacci(int n)
    {
        if (n == 0)
        {
            return 0;
        }
        else if (n == 1)
        {
            return 1;
        }
        else
        {
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
    // 3.5 Напишите программу на языке C# для вычисления мощности любого числа с использованием рекурсии. 
    // Входные данные :
    // Введите базовое значение : 5 
    // Введите экспоненту : 3 
    // Ожидаемый результат : Значение 5 в степени 3 равно : 125 
    public int Power(int n, int p)
    {
        if (p != 0)
        {
            return n * Power(n, p - 1);
        }
        return 1;
    }
}