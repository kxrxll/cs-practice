using System.Text.RegularExpressions;
public class Strings
{
    // 5.1 Вычислите длину строки, не используя библиотеки
    public int SelfMadeLengthChecker(string s)
    {
        int index = 0;
        while (true)
        {
            try
            {
                Char.IsLetter(s[index]);
                index += 1;
            }
            catch
            {
                return index;
            }
        }

    }
    // 5.2 Выведите уникальные буквы, цифры и символы в строке. Сосчитайте их кол-во и сопоставьте кол-ву символов в строке. (Пробел не считается за уникальный символ)
    // 		Входные данные: Hello 117!
    // 		Ожидаемый результат: 
    // H e l o 1 7 ! 
    // 7 / 9  
    public void CountUnique(string s)
    {
        string result = "";
        int spaces = s.Length;
        for (int i = 0; i < s.Length; i++)
        {
            if (!result.Contains(s[i]) && !s[i].Equals(' '))
            {
                result += s[i];
            }
            else if (s[i].Equals(' '))
            {
                spaces--;
            }
        }
        Console.WriteLine(result);
        Console.WriteLine($"{result.Length}/{spaces}");
    }
    // 5.3 Создайте функцию сравнения двух строк. Выведите результат: строка больше, меньше или равна. 
    public string StringEqualityCheck(string a, string b)
    {
        if (a.Length == b.Length)
        {
            return "Строки равны";
        }
        else if (a.Length > b.Length)
        {
            return "Первая строка больше";
        }
        else
        {
            return "Вторая строка больше";
        }
    }
    // 5.4 Вычислите сколько раз встречается одно и тоже слово в одном предложении 
    //  Входные данные: “привет привет мой дорогой друг” , “привет”
    //  Ожидаемый результат: 2
    public int SubstringCounter(string s, string subs)
    {
        return Regex.Matches(s, subs).Count;
    }
    // 5.5 Создайте программу, проверяющую совпадение логина и пароля
    // - Создайте функцию, создающую файл 
    // - Создайте функцию, записывающую в файл данные в формате “Логин” : “Пароль”. Каждой такой паре соответствует одна строка в файле
    // - Заполните файл несколькими парами логин и пароль. 
    // - Составьте функцию, запрашивающую логин пользователя
    // - При условии нахождения логина, запросите пароль у пользователя 
    // - При успешном прохождении аутентификации введите сообщение об успешном входе в систему. 
    // - При негативном прохождении аутентификации предложите зарегистрироваться в системе.
    public void AuthChecker()
    {
        string username = "";
        string password = "";
        bool passed = false;
        FileStream newFile = File.Create("files/passwords.txt");
        newFile.Close();
        using (StreamWriter outputFile = new StreamWriter("files/passwords.txt"))
        {
            outputFile.WriteLine("Anton:1234");
            outputFile.WriteLine("Tolya:2345");
            outputFile.WriteLine("Anna:3456");
        }
        Console.WriteLine("Введите имя: ");
        string? f = Console.ReadLine();
        if (f != null)
        {
            username = f;
        }
        Console.WriteLine("Введите пароль: ");
        string? l = Console.ReadLine();
        if (l != null)
        {
            password = l;
        }
        IEnumerable<string> lines = File.ReadLines("files/passwords.txt");
        foreach (string line in lines)
        {
            string[] pair = line.Split(":");
            if (pair[0] == username && pair[1] == password)
            {
                passed = true;
            }
        }
        if (passed)
        {
            Console.WriteLine("Вы авторизованы");
        }
        else
        {
            Console.WriteLine("ПОльзователь не найден");
        }
    }
}