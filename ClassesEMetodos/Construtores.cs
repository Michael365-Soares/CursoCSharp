using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class Construtores {
        public static void Executar() {
            Carro c1 = new Carro("FW100","Mercedes",2025);
            Console.WriteLine(c1.ToString());

            Carro c2 = new Carro();
            c2.Modelo = "FZ3000";
            c2.Fabricante = "Ferrari";
            c2.Ano = 2025;
            Console.WriteLine(c2.ToString());

            var c3 = new Carro() {
                Modelo="Fiat Argo",
                Fabricante="Fiat",
                Ano=2020
            };
            Console.WriteLine(c3.ToString());

        }
    }

    class Carro {
        public string Modelo { get; set; }
        public string Fabricante { get; set; }
        public int Ano { get; set; }

        public Carro() { }
        public Carro(string modelo,string fabricante, int ano) {
            this.Modelo = modelo;
            this.Fabricante = fabricante;
            this.Ano = ano;
        }

        public string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append($"O carro de modelo {this.Modelo} ");
            sb.Append($" é da fabricante {this.Fabricante} ");
            sb.Append($" e foi lançado no ano de  {this.Ano}.");
            return sb.ToString();
        }

    }

}
