using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresUnarios {
        public static void Executar() {
            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            bool booleano = true;
            Console.WriteLine(-valorNegativo);//Realiza a inversão de valores negativo/positivo ou positivo/negativo
            Console.WriteLine(!booleano);
            numero1++;
            numero1++;
            Console.WriteLine(numero1>numero2?$"{numero1} é maior do que {numero2}":$"{numero1} é menor do que {numero2}");
            numero1--;
            numero1--;
            Console.WriteLine(numero1>numero2?$"{numero1} é maior do que {numero2}":$"{numero1} é menor do que {numero2}");

            Console.WriteLine(numero1++==--numero2);
            Console.WriteLine($"{numero1} e {numero2}");

        }
    }
}
