using System;
using System.Collections;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    internal class ColecoesArrayList {
        public static void Executar() {
            var arraylist = new ArrayList{
                "Michael Soares",
                10,
                true,
                false
            };
            arraylist.Add(30.5);

            foreach (object item in arraylist) {
                Console.WriteLine(item+" Item do tipo: "+item.GetType());
            }

        }

    }
}
