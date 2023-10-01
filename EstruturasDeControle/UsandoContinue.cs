using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    internal class UsandoContinue {
        public static void Executar() {
            //int[,] matriz = new int[25,25];
            int[] numeros = new int[] { 1,2,3,4,5,6,7,8,9,1,10,11,12,13,14,15,16};
            for (int i=0;i<numeros.Length;i++) {
                if (numeros[i] % 2 != 0) {
                    continue;
                }
                    Console.WriteLine("O numero {0} é par.", numeros[i]);
            }
        }
    }
}
