using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class Conversoes {
        public static void Executar() {
            int inteiro = 15;
            double valorQuebrado = inteiro;
            Console.WriteLine(valorQuebrado);

            double nota = 9.7;
            int notaTruncada = (int)nota;
            Console.WriteLine(notaTruncada);

            Console.WriteLine("Informe sua idade:");
            string entrada=Console.ReadLine();
            try {
                int idade=int.Parse(entrada);
                Console.WriteLine("Idade informada foi de {0} anos.",idade);
                Console.WriteLine("Idade informada foi de {0} anos.",Convert.ToInt32(entrada));
            } catch(Exception e) {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Entrada inválida para a realização da converção, erro: "+e.Message);
            }

            Console.WriteLine("Informe um número:");
            entrada = Console.ReadLine();
            //int numeroConvertido = 0;
            int.TryParse(entrada, out int numeroConvertido);
            Console.WriteLine("O valor da conversão é igual a {0} .", numeroConvertido);

            Console.Write("Informe outro número:");
            int.TryParse(Console.ReadLine(),out int numero);
            Console.WriteLine("String convertida para o número de valor {0} .",numero);

        }
    }
}
