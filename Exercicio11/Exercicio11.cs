using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio11
{
    internal class Exercicio11
    {
        static string AlteraVogais(string informations)
        {
            char[] vogals = {'A', 'E', 'I', 'O', 'U' };
            informations = informations.ToUpper();

            for (int i = 0; i < vogals.Length; i++)
            {
                if(informations.Contains(vogals[i]))
                {
                    informations = informations.Replace(vogals[i], '*');
                }
            }

            return informations;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Digite as informações desejadas: ");
            string informations = Console.ReadLine();

            Console.WriteLine($"A string informada alterada fica da seguinte forma: {AlteraVogais(informations)}"); 

            Console.ReadLine();
        }
    }
}
