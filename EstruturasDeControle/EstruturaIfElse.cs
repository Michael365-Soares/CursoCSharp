using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    internal class EstruturaIfElse {
        public static void Executar() {

            bool bomComportamento = true;

            Console.Write("Digite a nota do aluno:");
            double.TryParse(Console.ReadLine(), out double nota);

            Console.WriteLine("Possui bom comportamento:(S/N)");
            string entrada = Console.ReadLine();
            bomComportamento = entrada == "S" || entrada == "s";
            //bomComportamento = entrada.ToUpper().Equals("S")?true:false;

            if ((nota >= 7.0 && nota <= 8.0) && bomComportamento) {
                Console.WriteLine("Aluno aprovado.");
            } else if (nota >= 8.0 && bomComportamento) {
                Console.WriteLine("Aluno aprovado com honras.");
            }

        }
    }
}
