using System;

class Program
{

    static string FormatUrl(string url)
    {
        url = url.Replace(" ", "%20");

        return url;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Informe a URL: ");
        string url = Console.ReadLine();
        string formattedUrl = FormatUrl(url);
        Console.WriteLine(formattedUrl.ToUpper());

        Console.ReadLine();
    }

    
}