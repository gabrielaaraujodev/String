using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    internal class Exercicio7
    {
        static string[,] DadosOrganizados(string[] novosDados)
        {
            string[,] informacoes = new string[4, 3];
            int cont = 0;

            for(int i = 0; i <  informacoes.GetLength(0); i++)
            {
                for(int j = 0; j < informacoes.GetLength(1); j++)
                {
                    informacoes[i, j] = novosDados[cont];
                    cont++;
                }
            }

            return informacoes;
        }
        static void Main(string[] args)
        {
            string dados = "nome,idade,sexo,Ana,25,F,João,30,M,Maria,22,F";
            string[] novosDados = dados.Split(',');

            string[,] informacoes = DadosOrganizados(novosDados);

            for (int i = 0; i < informacoes.GetLength(0); i++)
            {
                for (int j = 0; j < informacoes.GetLength(1); j++)
                {
                    Console.Write(informacoes[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
