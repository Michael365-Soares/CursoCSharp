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

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegorundColor = ConsoleColor.Black;

        }
    }
}
