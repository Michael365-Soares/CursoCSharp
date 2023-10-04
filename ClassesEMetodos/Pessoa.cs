using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    public class Pessoa {
        public string Nome { get; set; }
        public int Idade { get; set; }

        private string Apresentar;
        public Pessoa(string nome, int idade){
            this.Nome = nome;
            this.Idade = idade;
        }

        public void SetNome(string nome) {
            this.Nome = nome;
        }
        public string GetNome() {
           return  this.Nome;
        }

        public void SetIdade(int idade) {
            this.Idade = idade;
        }

        public int GetIdade() {
            return this.Idade;
        }

        public Pessoa Apresenta() {
            this.Apresentar= String.Format($"Olá! Eu sou(a) {this.GetNome()} e tenho {this.GetIdade()} anos.");
            return this;
        }

        public void ImprimirNoConsole() {
            Console.WriteLine(this.Apresentar);
        }

    }
}
