using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class ParametroPadrao {

        public static int Somar(int num1=5,int num2=10) {
            return num1 + num2;
        }
        public static void Executar() {
            Console.WriteLine(Somar(20,30));
            Console.WriteLine(Somar(num2:55));
        }
    }
}
