using System.Diagnostics; //Подключение пространства имен System.Diagnostics, которое содержит класс Process для запуска новых процессов.

internal class Program //Объявление класса Program. С ключевым словом internal, класс доступен только внутри текущей сборки.
{
    private static async Task Main(string[] args) //Объявление метода Main, который является точкой входа для программы. Он является асинхронным и возвращает объект Task.
    {
        HttpClient client = new();//Создание экземпляра класса HttpClient, который позволяет выполнять HTTP-запросы.

        Console.WriteLine("Введите ссылку для скачивания картинки: ");//Вывод сообщения на консоль с просьбой ввести ссылку для скачивания картинки. Затем считывается введенная пользователем строка и сохраняется в переменной namewebsite.
        string nameWebsite = Console.ReadLine();

        HttpResponseMessage response = await client.GetAsync(nameWebsite);//Выполняется GET-запрос с использованием HttpClient к указанной ссылке, и результат сохраняется в переменной response типа HttpResponseMessage.
        byte[] data = await response.Content.ReadAsByteArrayAsync();//Происходит асинхронное чтение содержимого ответа в виде массива байтов и сохранение его в переменной data типа byte[].

        await File.WriteAllBytesAsync("C:\\Users\\Nitro 5\\.git", data);//Асинхронная запись байтовых данных в файл с указанным путем "c:\\users\\nitro 5\\.git".

        Process.Start(new ProcessStartInfo { FileName = "C:\\Users\\Nitro 5\\.git", UseShellExecute = true });//Создание нового процесса с использованием ProcessStartInfo, указанного в качестве аргумента, и запуск указанного файла. UseShellExecute установлен в true, чтобы использовать оболочку ОС для запуска файла.
    }
}
