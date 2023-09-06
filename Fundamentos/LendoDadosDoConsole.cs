using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    public class LendoDadosDoConsole {
        public static void Executar() {
            Console.WriteLine("Digite seu nome:");
            string nome=Console.ReadLine();

            Console.WriteLine("Informe sua idade:");
            int idade =int.Parse(Console.ReadLine());

            Console.WriteLine("Informe seu salário:");
            double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine($"Nome:{nome}, Idade:{idade} e Salário:R${salario}");
        }
    }
}
