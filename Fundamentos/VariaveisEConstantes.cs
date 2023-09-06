using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    public class VariaveisEConstantes {
        public static void Executar() {
            //Área da circunferência
            double raio = 4.5;
            const double PI= 3.14;
            //Console.WriteLine("Informe o raio da circunferência:");
            //double.TryParse(Console.ReadLine(), out raio);
            double AreaDaCircunferencia= 3 * Math.PI * Math.Pow(raio,2);
            Console.BackgroundColor=ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("A área total da circunferência é de {0}", String.Format("{0:#.#,##}",AreaDaCircunferencia));
            Console.ResetColor();
            //Tipos primitivos da linguagem
            bool estarChovendo = true;
            int numero = 10;
            double numeroDouble = 5.55;
            float numeroFloat = 5.5555F;
            byte numeroByte = 15;
            sbyte numeroSByte = -127;
            short numeroShort = short.MaxValue;
            int numeroInt = int.MaxValue;
            //Esse tipo de int permite a utilização de separador para melhor visualização das casas númericas
            uint numeroUnit = 10_000_000;
            long numeroLong = long.MinValue;
            ulong numeroUlong = 2_000_000_000;
            decimal numeroDecimal = decimal.MaxValue;
            char letra = 'C';
            string nome = "Michael Soares de Oliveira";
        }
    }
}
