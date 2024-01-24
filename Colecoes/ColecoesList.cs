using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    internal class ColecoesList {
        public static void Executar() {
            var livro = new Produto("Livro Harry Potter",50.00);
            var carrinhoDeCompra = new List<Produto>();
            carrinhoDeCompra.Add(livro);
            carrinhoDeCompra.Add(new Produto("Lápis",2.50));
            carrinhoDeCompra.Add(new Produto("Caneta",2.00));
            carrinhoDeCompra.Add(new Produto("Borracha",1.00));
            carrinhoDeCompra.Add(new Produto("Caderno",15.00));

            var combo = new List<Produto>() {
                new Produto("Lápis",2.50),
                new Produto("Lápis",2.50),
                new Produto("Lápis",2.50),
                new Produto("Lápis",2.50),
                new Produto("Lápis",2.50),
                new Produto("Lápis",2.50)
            };
            carrinhoDeCompra.AddRange(combo);
            carrinhoDeCompra.RemoveAt(4);
            Console.WriteLine(carrinhoDeCompra.LastIndexOf(livro));

            carrinhoDeCompra.ForEach(p => Console.WriteLine($"O(a) {p.Nome} custa o valor de R$ {p.Preco.ToString("F2")}"));
            var rangeDeProduto = carrinhoDeCompra.GetRange(0,5);
            rangeDeProduto.ForEach(p=>Console.WriteLine($"O(a) {p.Nome} custa o valor de R$ {p.Preco.ToString("F2")}"));
            Console.WriteLine(carrinhoDeCompra.Remove(carrinhoDeCompra.GetRange(1,3).First()));
            carrinhoDeCompra.ForEach(p => Console.WriteLine($"O(a) {p.Nome} custa o valor de R$ {p.Preco.ToString("F2")}"));

        }

    }

    public class Produto {
        private string nome;
        private double preco;

        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto(string nome,double preco) {
            this.Nome = nome;
            this.Preco = preco;
        }

    }

}
