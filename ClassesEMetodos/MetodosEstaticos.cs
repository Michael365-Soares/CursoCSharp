using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    public class MetodosEstaticos {
        public static void Executar() {
            Console.WriteLine($"O resultado da soma é {Calculadora.somar(10,15).ToString("F2")}");
            Console.WriteLine(Calculadora.subtrair(10,15));
            Console.WriteLine(Calculadora.multiplicar(10,15));
            Console.WriteLine(Calculadora.dividir(10, 15));
            Console.WriteLine(Calculadora.modulo(10, 15));

        }

    }

    class Calculadora{

        private static double Resultado;
        private double Resultado1 { get; set; }

        //Métodos de classe ou estáticos
        public static Double somar(double num1, double num2) {
            Resultado=num1+num2;
            return Resultado;
        }

        public static Double subtrair(double num1, double num2) {
            Resultado = num1 - num2;
            return Resultado;
        }

        public static Double multiplicar(double num1, double num2) {

            Resultado = num1 * num2;
            return Resultado;
        }

        public static Double dividir(double num1, double num2) {
            Resultado = num1 / num2;
            return Resultado;
        }

        public static Double modulo(double num1, double num2) {
            Resultado = num1 % num2;
            return Resultado;
        }

    }

}
