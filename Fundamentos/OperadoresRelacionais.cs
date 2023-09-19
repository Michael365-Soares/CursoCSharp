using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresRelacionais {
        public static void Executar() {
            var nota = 6.0;
            var notaDeCorte = 7.0;
            string status = nota > notaDeCorte ? $"Parabéns você foi aprovado com a nota {nota}" :
                $"Que Pena! Sua nota {nota} não foi o suficiente.";
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(status);
            Console.ResetColor();
            Console.WriteLine("Informe sua nota por favor:");
            double.TryParse(Console.ReadLine(), out double notaInserida);
            bool notaValida = notaInserida >= 0.0 && notaInserida <= 10.0 ? true : false;
            if (notaValida==false) {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($" A nota {notaInserida.ToString("F2")} é inválida!!!");
                Console.ResetColor();
            } else if (notaInserida >= notaDeCorte) {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Você foi aprovado com a nota {notaInserida.ToString("F2")}");
            } else if (notaInserida <= notaDeCorte) {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Você foi reprovado com a nota {notaInserida.ToString("F2")}");
            } else if (notaInserida == 10) {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Você foi aprovado com honras com a nota {notaInserida.ToString("F2")}");
            } 

        }
    }
}
