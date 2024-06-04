using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio13
{
    internal class Exercicio13
    {
        static int QntVezesQueContabiliza(string frase, string B)
        {
            frase = frase.ToUpper();
            B = B.ToUpper();

            int index = 0;

            index = frase.IndexOf(B);

            if (frase.Contains(B))
            {
                return index;
            }

            return -1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Informa uma frase com, no mínimo, 50 caracteres: ");
            string frase = Console.ReadLine();

            Console.WriteLine("Informa 2 (dois) caracteres: ");
            string B = Console.ReadLine();

            int cont = 0;
            if (B.Length < 0 || B.Length > 2)
            {
                Console.WriteLine("Informe corretamente o que foi pedido !");
            }
            else
            {
                cont = QntVezesQueContabiliza(frase, B);
            }

            Console.WriteLine($"O número da 1ª posição em que os caracteres '{B}' aparecem na frase é: {cont}");
            Console.ReadLine();
        }
    }
}
