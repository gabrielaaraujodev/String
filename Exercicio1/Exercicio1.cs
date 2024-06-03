using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Exercicio1
    {
        static string VerificarStrings(string textoUm, string textoDois)
        {
            bool comparaTexto = textoUm.Equals(textoDois);

            if (comparaTexto)
            {
                return "São iguais";
            }
            else
            {
                return "Não são iguais";
            }
        }
        static bool AhStringSucede(string textoUm, string textoDois)
        {
                int sucede = textoUm.CompareTo(textoDois);
                
                if(sucede != 1)
                {
                    return false;
                }

            return true;
        }

        static string RetornaConcatenacaoDeString(string textoUm, string textoDois)
        {
            return textoUm + textoDois; 
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um texto ou palavra qualquer: ");
            string textoUm = Console.ReadLine();

            Console.WriteLine("Informe um texto ou palavra qualquer: ");
            string textoDois = Console.ReadLine();

            Console.WriteLine(VerificarStrings(textoUm, textoDois));  
            Console.WriteLine(AhStringSucede(textoUm, textoDois));
            Console.WriteLine(RetornaConcatenacaoDeString(textoUm, textoDois)); 

            Console.ReadLine();
        }
    }
}
