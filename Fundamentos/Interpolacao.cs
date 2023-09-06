using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    public class Interpolacao {
        public static void Executar() {
            string nome = "Notebook Gamer";
            string marca = "Dell";
            double preco = 5800.00;
            Console.WriteLine("{0} {1} custa o valor de R$ {2}",nome,marca,preco);
            Console.WriteLine("O "+nome+" da marca "+marca+" custa o valor de R$ "+preco);
            Console.WriteLine($"A marca {marca} é legal!");
            Console.WriteLine($"1+1={1+1}");
        }
    }
}
