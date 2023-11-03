
using System.Security.Cryptography.X509Certificates;

public class Functions
{
    // Создайте функцию, выводящую по номеру месяца его название
    // 	Входные данные: 3
    // 	Ожидаемый результат: Март.
    public string GetMonthByNumber(int num)
    {
        var months = new Dictionary<int, string>()
        {
            { 1, "Январь"},
            { 2, "Февраль"},
            { 3, "Март"},
            { 4, "Апрель"},
            { 5, "Май"},
            { 6, "Июнь"},
            { 7, "Июль"},
            { 8, "Август"},
            { 9, "Сентябрь"},
            { 10, "Октябрь"},
            { 11, "Ноябрь"},
            { 12, "Декабрь"}
        };
        return months[num];
    }
    // Найдите соответствие между символом Char и его кодировкой
    // Входные данные: A
    // Ожидаемый результат: 65
    public int ReturnCharCode(char ch)
    {
        return ch;
    }
    // Переведите массив, состоящий из цифр и символов в символьный формат:
    // Входные данные: [‘hello’, 1811, ‘goodbye’’]
    // Ожидаемый результат: [‘hello’, ‘1811’, ‘goodbye’’]
    public void ArrayToStrings(List<object> arr)
    {
        List<string> output_data = new List<string>();
        foreach (object? item in arr)
        {
            output_data.Add(item.ToString());
        }
        Console.WriteLine(string.Join(", ", output_data));
    }
    // 6.4 Переведите число в бинарный формат и сосчитайте кол-во единиц
    // Входные данные: 12
    // Ожидаемый результат 2 (От бинарного числа 1100)
    public int CalculateOneInBinaryRepresentation(int n)
    {
        string bin = Convert.ToString(n, 2);
        return bin.Split('1').Length - 1;
    }
    // 6.5 Уберите все символьные значения из массива, созданного из чисел и строк
    // Входные данные: [881, ‘laugh’, 16, ‘b’, ‘k’, ‘programming’]
    // Выходные данные: [881, 16]
    public void ArrayToIntArray(List<object> arr)
    {
        List<object> output_data = arr.FindAll(e => e is int);
        Console.WriteLine(string.Join(", ", output_data));
    }
}


