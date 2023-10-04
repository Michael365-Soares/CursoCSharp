using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class MetodosComRetorno {
        public static void Executar() {
            CalculadoraComum cal1 = new CalculadoraComum();
            Console.WriteLine(cal1.Somar(5,58));
            Console.WriteLine(cal1.Somar(5,58,5));
            Console.WriteLine(cal1.Subtrair(5,58));
            Console.WriteLine(cal1.Dividir(5,58));
            Console.WriteLine(cal1.Multiplicar(5,58));
            Console.WriteLine("===CALCULADORA ENCADEADA===");
            CalculadoraEncadeada cal2 = new CalculadoraEncadeada();
            Console.WriteLine(cal2.Somar(5).Somar(5).Multiplicar(5).Dividir(2).ResultadoDaOperacao());

        }
    }

    class CalculadoraComum {
        public int Somar(int a,int b) {
            return a + b;
        }

        public int Somar(int a, int b, int c) {
            return a + b + c;
        }

        public int Subtrair(int a ,int b) {
            return a - b;
        }

        public int Multiplicar(int a,int b) {
            return a * b;
        }

        public int Dividir(int a, int b ) {
            return a / b;
        }

    }

    class CalculadoraEncadeada{

        private int  Resultado;

        public CalculadoraEncadeada() {}
        public CalculadoraEncadeada Somar(int num) {
            this.Resultado +=num;
            return this;
        }

        public CalculadoraEncadeada Subtrair(int num) {
            this.Resultado -=num;
            return this;
        }

        public CalculadoraEncadeada Multiplicar(int num) {
            this.Resultado *=num;
            return this;
        }
        public CalculadoraEncadeada Dividir(int num) {
            this.Resultado /=num;
            return this;
        }

        public int ResultadoDaOperacao() {
            return this.Resultado;
        }

    }

}
