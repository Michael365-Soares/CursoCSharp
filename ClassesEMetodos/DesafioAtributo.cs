using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class DesafioAtributo {

        private int a = 10;
        public static void Executar() {
            //Acessar a variável dentro do método Executar!
            DesafioAtributo da = new DesafioAtributo();
            Console.WriteLine(da.a);
        }

    }
}
