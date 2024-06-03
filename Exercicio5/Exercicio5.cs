using System;
using System.ComponentModel;
using System.Linq;

class Program
{
    static bool EhPalindromo(string str)
    {
        int tamanho = str.Length;
        string[] letras = new string[tamanho];
        int i = 0;
        foreach (char s in str)
        {
            letras[i] = s.ToString();
            i++;
        }

        string novaPlavra = "";
        for (i = letras.Length - 1; i >= 0; i--) {
            novaPlavra += letras[i];
        }


        if (str == novaPlavra)
        {
            return true;
        }

        return false;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Informe uma palavra: ");
        string palavra = Console.ReadLine();
        Console.WriteLine($"A palavra '{palavra}' é um palíndromo? {EhPalindromo(palavra)}");
        Console.ReadLine();
    }

    
}