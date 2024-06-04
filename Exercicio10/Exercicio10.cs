using System;

class Program
{
    static int CountFilesWithExtension(string[] files, string extension)
    {
        int cont = 0;
        for (int i = 0; i < files.Length; i++)
        {
            if (files[i].EndsWith(extension))
            {
                cont++;
            }
        }

        return cont;
    }
    static void Main(string[] args)
    {
        string[] files = { "document.txt", "image.jpg", "data.csv", "script.js" };
        Console.WriteLine("Informa o nome da extensão do arquivo desejado: ");
        string extension = Console.ReadLine();

        int count = CountFilesWithExtension(files, extension);
        Console.WriteLine($"Número de arquivos com a extensão '{extension}': {count}");
        Console.ReadLine();
    }

    
}