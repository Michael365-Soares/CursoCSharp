using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos{
    class Membros{
        public static void Executar() {
            Console.WriteLine("Informe seu nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe sua idade:");
            int.TryParse(Console.ReadLine(),out int idade);

            Pessoa p = new Pessoa(nome,idade);
            p.Apresenta().ImprimirNoConsole();

            var p1 = new Pessoa("Lucas Ryan",09);
            p1.Apresenta().Apresenta().ImprimirNoConsole();

        }
    }
}
