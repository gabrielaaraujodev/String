using System;

class Program
{
    static int CountFilesWithExtension(string[] files, string extension)
    {
        int count = 0;
        foreach (string file in files)
        {
            if (file.EndsWith(extension, StringComparison.OrdinalIgnoreCase))
            {
                count++;
            }
        }
        return count;
    }
    static void Main(string[] args)
    {
        string[] files = { "document.txt", "image.jpg", "data.csv", "script.js" };
        string extension = ".txt";
        int count = CountFilesWithExtension(files, extension);
        Console.WriteLine($"Número de arquivos com a extensão '{extension}': {count}");
        Console.ReadLine();
    }

    
}