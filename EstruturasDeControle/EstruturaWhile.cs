using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    internal class EstruturaWhile {
        public static void Executar() {

            int numeroAleatorio = 0;
            int entrada = 0;
            Random aleatorio = new Random();
            numeroAleatorio=aleatorio.Next(0,21);
            
            while (numeroAleatorio!=entrada) {
                Console.WriteLine("Informe um número aleatório entre 0 e 20:");
                int.TryParse(Console.ReadLine(),out entrada);

                if (entrada>numeroAleatorio) {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine($"O número {entrada} é maior que o número aleatório.");
                } else if (entrada<numeroAleatorio) {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine($"O número {entrada} é menor que o número aleatório.");
                    Console.ResetColor();
                } else {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Parabéns você acertou!!!");
                    Console.ResetColor();
                }

            }

        }
    }
}
