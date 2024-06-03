using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    
    internal class Exercicio6
    {
        static string VerficiarTerminacaoVerbo(string palavra)
        {
            Console.WriteLine("Informe um verbo terminado em AR: ");
            palavra = Console.ReadLine();
            palavra = palavra.ToUpper();
            bool controle = true;

            do
            {
                if (palavra.EndsWith("AR"))
                {
                    controle = false;
                }
                else
                {
                    Console.WriteLine("Informe um verbo terminado em AR: ");
                    palavra = Console.ReadLine();
                    palavra = palavra.ToUpper();
                }

            } while (controle);

            return palavra;
        }

        static void ConjugacoesVerbais(string verbo, string[] presenteIndicativo, string[] preteritoPrefeito, string[] futuroPresente)
        {
            string[] conjugacoes = new string[presenteIndicativo.Length * 3];
            verbo = verbo.Remove(verbo.Length-2);

            Console.WriteLine("Presente do Indicativo");
            for (int i = 0; i < presenteIndicativo.Length; i++)
            {
                Console.WriteLine(verbo + presenteIndicativo[i].ToUpper());
            }

            Console.WriteLine();
            Console.WriteLine("Pretérito Perfeito");
            for (int i = 0; i < presenteIndicativo.Length; i++)
            {
                Console.WriteLine(verbo + preteritoPrefeito[i].ToUpper());
            }

            Console.WriteLine();
            Console.WriteLine("Futuro do Presente");
            for (int i = 0; i < futuroPresente.Length; i++)
            {
                Console.WriteLine(verbo + futuroPresente[i].ToUpper());
            }

        }
        static void Main(string[] args)
        {
            string verbo = " ";
            string[] presenteIndicativo = {"o","as","a","amos","as","am"};
            string[] preteritoPrefeito = {"ei","aste","ou","amos","astes","aram"};
            string[] futuroPresente = {"arei","arás","ará","aremos","areis","arão" };
            
            verbo = VerficiarTerminacaoVerbo(verbo);

            Console.WriteLine($"O verbo informado foi: {verbo}");
            Console.WriteLine();

            ConjugacoesVerbais(verbo, presenteIndicativo,preteritoPrefeito,futuroPresente);
            Console.ReadLine();
        }
    }
}
