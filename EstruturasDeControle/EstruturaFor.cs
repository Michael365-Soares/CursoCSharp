using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    internal class EstruturaFor {
        public static void Executar() {
            string[,] matriz = new string[10,10];
            int indice = 0;
            for (var i=0;i<10;i++) {
                for (var j=0;j<10;j++) {
                    matriz[i, j] =indice<10?$"0{indice}":indice.ToString();
                    indice++;
                    Console.Write("[" + matriz[i,j].ToString()+"]");            
                 }
                Console.WriteLine();
            }

        }
    }
}
