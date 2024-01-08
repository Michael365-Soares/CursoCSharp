using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class StructVsClass {

        public static void Executar() {

            //Struct passam suas cópias por referência de valor
            SPonto ponto1 = new SPonto { X=1, Y=3};
            SPonto copiaPonto1 = ponto1;//Atribuição por VALOR!!!
            ponto1.X = 3;
            Console.WriteLine($"ponto1 X={ponto1.X}");
            Console.WriteLine($"copiaPonto1 x={copiaPonto1.X}");

            //Class passam suas cópias por referência de memória
            CPonto ponto2 = new CPonto { X=2, Y=4};
            CPonto copiaPonto2 = ponto2;
            ponto2.X = 3;
            Console.WriteLine($"ponto2 X={ponto2.X}");
            Console.WriteLine($"copiaPonto2 X={copiaPonto2.X}");

        }

    }

    public struct SPonto {
        public int X;
        public int Y;
    }

    public class CPonto {
        public int X;
        public int Y;
    }

}
