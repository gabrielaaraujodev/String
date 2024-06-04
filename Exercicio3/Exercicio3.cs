using System;

class Program
{
    static string IntercalaString(string primeiraPalavra, string segundaPalavra)
    {
        string newString = "";
        int indexPrimeiraPalavra = 0;
        int indexSegundaPalavra = 0;
        bool control = true;
        string troca = "";

        if (primeiraPalavra.Length < segundaPalavra.Length)
        {
            troca = primeiraPalavra;
            primeiraPalavra = segundaPalavra;
            segundaPalavra = troca;
        }

        do
        {
            if (indexSegundaPalavra < segundaPalavra.Length)
            {
                newString += primeiraPalavra[indexPrimeiraPalavra].ToString() + segundaPalavra[indexSegundaPalavra].ToString();
                indexPrimeiraPalavra++;
                indexSegundaPalavra++;
            } else if (indexPrimeiraPalavra < primeiraPalavra.Length)
            {
                newString += primeiraPalavra[indexPrimeiraPalavra];
                indexPrimeiraPalavra++;
            }

            if(indexPrimeiraPalavra >= primeiraPalavra.Length && indexSegundaPalavra >= segundaPalavra.Length)
            {
                control = false;
            }


        } while (control);

        return newString;
 
    }


    static void Main(string[] args)
    {
        Console.WriteLine("Informe a 1ª palavra: ");
        string primeiraPalavra = Console.ReadLine();

        Console.WriteLine();

        Console.WriteLine("Informe a 2ª palavra: ");
        string segundaPalavra = Console.ReadLine();

        Console.WriteLine($"As strings intercaladas geram a seguinte palavra: {IntercalaString(primeiraPalavra, segundaPalavra)}"); 

        Console.ReadLine();
    }
}