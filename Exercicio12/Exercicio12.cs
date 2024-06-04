using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio12
{
    internal class Exercicio12
    {
        static int QntVezesQueContabiliza (string frase, string B)
        {
            frase = frase.ToUpper();
            B = B.ToUpper();
            int cont = 0;
            int index = 0;

            do
            {
                index = frase.IndexOf(B);

                if (frase.Contains(B))
                {
                    cont++;
                    frase = frase.Remove(index, 2);
                }

            } while(index != -1);
            
            return cont;
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
            } else
            {
                cont = QntVezesQueContabiliza(frase, B);
            }

            Console.WriteLine($"O número de vezes que os caracteres {B} aparecem na frase é (são): {cont} vezes");
            Console.ReadLine();
        }
    }
}
