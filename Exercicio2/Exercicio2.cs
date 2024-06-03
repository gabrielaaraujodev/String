using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Exercicio2
    {
        static void NumeroVogais (string texto, out int qntVogal, out int qntConsoante)
        {
            qntVogal = 0;
            qntConsoante = 0;
            texto = texto.ToUpper();

            foreach (int letra in texto)
            {
            Console.WriteLine(letra);

                if (letra == 65 || letra == 69 || letra == 73 || letra == 79 || letra == 85)
                {
                    qntVogal++;
                }
                else
                {
                    qntConsoante++;
                }
            }
        }

        static void Main(string[] args)
        {
            int qntVogal;
            int qntConsoante;
            Console.WriteLine("Escreva um texto ou uma palavra: ");
            string texto = Console.ReadLine();

            NumeroVogais(texto, out qntVogal, out qntConsoante);
            Console.WriteLine($"A quantidade de vogais é: {qntVogal}");
            Console.WriteLine($"A quantidade de consoante é: {qntConsoante}");

            Console.ReadLine();
        }
    }
}
