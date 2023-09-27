using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    internal class EstruturaSwitch {
        public static void Executar() {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("====CALCULADORA COM SWITCH/CASE===========");
            Console.ResetColor();

            Console.WriteLine("Informe o primeiro número:");
            Double.TryParse(Console.ReadLine(),out double n1);
            Console.WriteLine("Informe o tipo de operação que deseja realizar:(+,-,*,/ ou %)");
            string op = Console.ReadLine();
            Console.WriteLine("Informe o segundo número:");
            Double.TryParse(Console.ReadLine(),out double n2);

            switch (op) {
                case "+":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    double resultado = n1 + n2;
                    Console.WriteLine($"A soma de {n1}+{n2}={resultado}");
                    Console.ResetColor();
                    break;
                case "-":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    resultado = n1 - n2;
                    Console.WriteLine($"A subtração de {n1}-{n2}={resultado}");
                    Console.ResetColor();
                    break;
                case "*":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    resultado = n1 * n2;
                    Console.WriteLine($"A multiplicação de {n1}*{n2}={resultado}");
                    Console.ResetColor();
                    break;
                case "/":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    resultado = n1 / n2;
                    Console.WriteLine($"A divisão de {n1}/{n2}={resultado}");
                    Console.ResetColor();
                    break;
                case "%":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    resultado = n1 % n2;
                    Console.WriteLine($"O resto da divisão de {n1}%{n2}={resultado}");
                    Console.ResetColor();
                    break;
                default:
                    Console.WriteLine("Algo de errado aconteceu!");
                    break;
            }

        }
    }
}
