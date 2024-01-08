using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class ValorVsReferencia {
        public static void Executar() {
            int numero = 3;
            int copiaNumero = numero;
            Console.WriteLine($"Cópia número:{copiaNumero}|Número:{numero}");
            numero++;
            Console.WriteLine($"Cópia número:{copiaNumero}|Número:{numero}");

            var dep01 = new Dependente() { 
                Nome="Michael S.",
                Idade=29
            };
            Console.WriteLine($"Nome:{dep01.Nome}|Idade:{dep01.Idade} => Original");
            var dep01Copia = dep01;
            dep01Copia.Nome = "João";
            dep01Copia.Idade = 13;
            Console.WriteLine($"Nome:{dep01.Nome}|Idade:{dep01.Idade} =>Original depois de alterar sua referência na cópia");

        }
    }

    public class Dependente {
        public string Nome { get; set; }
        public int Idade { get; set; }

    }

}
