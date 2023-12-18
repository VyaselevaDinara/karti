using System.Diagnostics;

internal class Program
{
    private static async Task Main(string[] args)
    {
        HttpClient client = new();

        Console.WriteLine("Введите ссылку для скачивания картинки: ");
        string nameWebsite = Console.ReadLine();

        HttpResponseMessage response = await client.GetAsync(nameWebsite);
        byte[] data = await response.Content.ReadAsByteArrayAsync();

        await File.WriteAllBytesAsync("C:\\Users\\Nitro 5\\.git", data);

        Process.Start(new ProcessStartInfo { FileName = "C:\\Users\\Nitro 5\\.git", UseShellExecute = true });
    }
}
