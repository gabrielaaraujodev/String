using System;

class Program
{
    static string IntercalaString(string primeiraPalavra, string segundaPalavra)
    {
        for (int i = 1; i < primeiraPalavra.Length; i = i + 2)
        {
            primeiraPalavra = primeiraPalavra.Replace(primeiraPalavra[i], ' ');
        }

        foreach (char letra in primeiraPalavra)
        {
            if (letra == ' ')
            {

            }
        }

        Console.WriteLine(primeiraPalavra);

        return "";
    }


    static void Main(string[] args)
    {
        Console.WriteLine("Informe a 1ª palavra: ");
        string primeiraPalavra = Console.ReadLine();

        Console.WriteLine();

        Console.WriteLine("Informe a 2ª palavra: ");
        string segundaPalavra = Console.ReadLine();

        IntercalaString(primeiraPalavra, segundaPalavra);

        Console.ReadLine();
    }
}