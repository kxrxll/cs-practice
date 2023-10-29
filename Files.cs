public class Files
{
    string fileName = "test.txt";
    string folderName = "files";
    string pathName = "";
    string content = "";
    public void CreateFile()
    {
        // Работа с файлами 
        // 4.1 Напишите программу, создающую пустой файл с определенным именем 
        // - Создайте функцию, запрашивающую имя файла через консоль 
        // - Создайте функцию, создающую файл в пустой папке проекта
        // - Модифицируйте функцию: 
        // - Задайте дополнительный параметр для функции создания файла - расположение папки, где будет создан файл 
        // - Если в функцию вместо аргумента расположения файла передан “-” -> создайте пустой файл в папке проекта.
        Console.WriteLine("Введите название файла: ");
        string? f = Console.ReadLine();
        if (f != null)
        {
            fileName = f;
        }
        Console.WriteLine("Введите название папки или \"-\" для создания файла в корневом каталоге: ");
        string? l = Console.ReadLine();
        if (l != null)
        {
            folderName = l;
        }
        if (folderName == "-")
        {
            pathName = fileName;
        }
        else
        {
            pathName = $"{folderName}/{fileName}";
        }
        Console.WriteLine("Введите текст файла: ");
        string? n = Console.ReadLine();
        if (n != null)
        {
            content = n;
        }
        if (!File.Exists(pathName))
        {
            if (!Directory.Exists(folderName))
            {
                Directory.CreateDirectory(folderName);
            }
            FileStream newFile = File.Create(pathName);
            newFile.Close();
            Console.WriteLine("Файл был успешно создан.");
        }
        else
        {
            Console.WriteLine("Ошибка, файл с таким именем существует.");
        }
        // 4.2 Напишите программу, создающую файл с текстом, затем выведите его на экран. 
        // - Модифицируйте программу: 
        // - создайте функцию с возможность записи информации в файл
        // - создайте функцию, удаляющую всю информацию из файла
        File.WriteAllText(Path.Combine(folderName, fileName), content);
        Console.WriteLine("Записали текст в файл.");
        File.WriteAllText(Path.Combine(folderName, fileName), "");
        Console.WriteLine("Удалили текст в файле.");
        // 4.3 Напишите программу, читающую 1, 3 и 5 строки из файла. 
        string[] lines = File.ReadAllLines("files/test.txt");
        Console.WriteLine($"Первая строка: {lines[0]}");
        Console.WriteLine($"Третья строка: {lines[2]}");
        Console.WriteLine($"Пятая строка: {lines[4]}");
        // 4.5 Напишите программу, считающую кол-во строк в файле.
        Console.WriteLine($"Всего строк: {lines.Length}");
        // 4.4 Напишите программу, считающую кол-во упоминаний слова “Привет”
        string text = File.ReadAllText("files/test.txt");
        string[] source = text.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);
        IEnumerable<string> matchQuery = from word in source
                                         where word.Equals("привет", StringComparison.InvariantCultureIgnoreCase)
                                         select word;
        int wordCount = matchQuery.Count();
        Console.WriteLine("{0} раз встретилось слово \"{1}\".", wordCount, "привет");

    }
}

