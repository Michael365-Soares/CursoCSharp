using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    internal class FormatandoNumero {
        public static void Executar() {
            double valor = 15.757;

            //Formatando valor para uma casa decimal
            Console.WriteLine("Formatando valor para uma casa decimal");
            Console.WriteLine(valor.ToString("F1"));

            //Formatando o valor para valor monetário corrente
            Console.WriteLine("Formatando o valor para valor monetário corrente");
            Console.WriteLine(valor.ToString("C"));

            //Formatando o valor no formato porcentagem
            Console.WriteLine("Formatando o valor no formato porcentagem");
            Console.WriteLine(valor.ToString("P"));

            //Formatando valor de forma personalizada
            Console.WriteLine("Formatando valor de forma personalizada");
            Console.WriteLine(valor.ToString("#.##"));

            Console.WriteLine("Formatando o valor de forma configurada pela região por meio da classe CultureInfo...");
            CultureInfo cultureInfo = new CultureInfo("pt-BR");
            Console.WriteLine(valor.ToString("C2",cultureInfo));

            Console.WriteLine("Inserindo zero a esquerda de números inteiros....");
            int inteiro = 255;
            Console.WriteLine(inteiro.ToString("D10")); ;
        }
    }
}
