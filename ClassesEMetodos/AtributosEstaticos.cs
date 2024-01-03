using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class AtributosEstaticos {

        public static void Executar() {
            Produto.Desconto = 0.5;
            Produto prod1 = new Produto("Caneta",3.2);
            var prod2 = new Produto() {
                Nome = "Lápis",
                Preco =5.3,
            };

            Console.WriteLine($"Preço com desconto do produto {prod1.Nome} é de R$ {prod1.CalcularDesconto().ToString("F2")}");
            Console.WriteLine("O preço com desconto do produto {0} é de R$ {1}",
            prod2.getNome(),prod2.CalcularDesconto().ToString("F2"));

        }
       class Produto{
            public string Nome { get; set; }
            public double Preco;
            public static double Desconto = 0.1;

            public Produto(string nome,double preco) {
                this.setNome(nome);
                this.Preco = preco;
            }

            public Produto() { }

            public double CalcularDesconto() {
                return Preco - (Preco * Desconto);
            }

            public string getNome() {
                return this.Nome;
            }

            public void setNome(string nome) {
                this.Nome=nome;
            }


        }

    }
}
