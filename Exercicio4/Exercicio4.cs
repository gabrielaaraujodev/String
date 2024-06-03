using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    internal class Exercicio4
    {
        /*NÃO ESTÁ CORRETO, PRECISO AJUSTAR O ERRO !*/
        static string MaiorSubstring(string texto, char delUm, char delDois)
        {
            string result = "";
            int maiorTamanho = int.MinValue;

            do
            {
                int posicaoInicial = texto.IndexOf(delUm);
                int posicaoFinal = texto.IndexOf(delDois);
                string substring = texto.Substring(posicaoInicial, ((posicaoFinal + 1) - posicaoInicial));
           
                if(substring.Length > maiorTamanho)
                {
                    result = substring;
                    maiorTamanho = substring.Length;
                }

                texto = texto.Replace(substring, "-");

            } while(texto.Contains(delUm));

            if (result.Length == 0)
            {
                    return " ";
            }

            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva uma string: ");
            string texto = Console.ReadLine();

            char delUm = '(';
            char delDois = ')';

            Console.WriteLine($"A maior substring será: {MaiorSubstring(texto, delUm, delDois)}");

            Console.ReadLine();
          
        }
    }
}