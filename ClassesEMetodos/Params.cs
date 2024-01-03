using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class Params {

        static void Recepcionar(params String[] pessoas) {
            foreach(var p in pessoas) {
                Console.WriteLine($"Olá Sr.(ª/º) {p}");
            }
        }
        public static void Executar() {
            Recepcionar("Michael","Ryan","Antonia");
        }

    }
}
