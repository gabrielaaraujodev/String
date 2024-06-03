using System;

class Program
{
    static bool[] CheckPalindromes(string words)
    {
        string[] separatedWords = words.Split(' ');
        string[] reverseWords = new string[separatedWords.Length];

        int cont = 0;

        foreach(string texto in separatedWords)
        {
            string palavra = "";
            for(int i = texto.Length - 1; i >= 0; i--)
            {
                palavra += texto[i];
            }

            reverseWords[cont] = palavra;
            cont++;
        }

        bool[] result = new bool[reverseWords.Length];

        for (int i = 0; i < reverseWords.Length; i++)
        {
            if (reverseWords[i] == separatedWords[i])
            {
                result[i] = true;
            } else
            {
                result[i] = false;
            }
        }

        return result;

    }


    static void Main(string[] args)
    {
        Console.WriteLine("Informe diversas palavras: ");
        string words = Console.ReadLine();
        bool[] palindromes = CheckPalindromes(words); 

        foreach (bool palindrome in palindromes)
        {
            Console.Write(palindrome + " ");
        }

        Console.ReadLine();
    }

    
}