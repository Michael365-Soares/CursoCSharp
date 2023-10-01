using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    internal class EstruturaDoWhile {
        public static void Executar() {
            int contador = 0;
            double[] notas = new double[10];
            double somaTotalNotas = 0;
            do {
                Console.WriteLine($"Por favor insira a {(contador+1)}ª:");
                Double.TryParse(Console.ReadLine(),out notas[contador]);
                contador++;
            } while (contador<10);

            foreach (var item in notas){
                somaTotalNotas += item;
            }

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("A média final foi de: {0}",(somaTotalNotas/notas.Length).ToString("F1"));
            Console.ResetColor();

        }
    }
}
