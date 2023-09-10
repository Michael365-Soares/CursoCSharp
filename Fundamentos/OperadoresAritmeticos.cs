using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresAritmeticos {
        public static void Executar() {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("====PRATICANDO COM OPERADORES ARITMÉTICOS=====");
            Console.ResetColor();
            Console.Write("Informe o primeiro inteiro positivo número:");
            int.TryParse(Console.ReadLine(), out int num01);
            Console.Write("Informe o segundo inteiro positivo número:");
            int.TryParse(Console.ReadLine(),out int num02);

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("=========ADIÇÃO============");
            Console.ResetColor();
            Console.WriteLine($"A soma de {num01} e {num02} é igual a {(num01+num02).ToString("D3")}");

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("=========SUBTRAÇÃO============");
            Console.ResetColor();
            Console.WriteLine("A subtração de {0} menos {1} é igual a {2}",num01,num02,(num01-num02).ToString("D3"));

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("=========MULTIPLICAÇÃO============");
            Console.ResetColor();
            Console.WriteLine("A multiplicação de "+num01+" vezes "+num02+" é igual a "+(num01*num02).ToString("D3"));

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("=========DIVISÃO============");
            Console.ResetColor();
            Console.WriteLine($"A divisão entre {num01} e {num02} é igual a {(num01/num02).ToString("F2")}");

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("=========RESTO DA DIVISÃO============");
            Console.ResetColor();
            Console.WriteLine($"O resto da divisão entre {num01} e {num02} é igual a {(num01%num02).ToString("F2")}");

        }
    }
}
