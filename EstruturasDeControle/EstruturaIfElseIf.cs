using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    internal class EstruturaIfElseIf {
        public static void Executar() {
            Console.Write("Informe a nota do aluno:");
            double.TryParse(Console.ReadLine(),out double nota);
            Console.WriteLine("O aluno possui bom comportamneto?(S/N)");
            bool bomComportamento = Console.ReadLine()=="s".ToLower() ? true : false;

            if ((nota >= 7.0 && nota < 8.0) && bomComportamento) {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Aluno aprovado dentro das expectativas!");
                Console.ResetColor();
            } else if (nota >= 8.0 && bomComportamento) {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Aluno aprovado com mensão honrosa!");
                Console.ResetColor();
            } else if ((nota >= 6.0 && nota < 7.0) && bomComportamento) {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Aluno em recuperação.");
                Console.ResetColor();
            } else {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Aluno reprovado.");
                Console.ResetColor();
            }

        }
    }
}
