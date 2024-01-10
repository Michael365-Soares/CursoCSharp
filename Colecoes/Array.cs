using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    internal class Array {
        public static void Executar() {
            string[] alunos = new string[5];

            for (int i=0;i<alunos.Length;i++) {
                Console.WriteLine($"Informe {i}º nome");
                alunos[i] = Console.ReadLine();
            }
            Console.Write("\n");

            foreach (var item in alunos){
                Console.WriteLine(item+"\n");
            }

            double somatorio = 0;
            double[] notas = {9.8,8.5,5.5,8.8,6.9};
            foreach (var nota in notas) {
                somatorio += nota;
            }
            Console.WriteLine($"A média geral é de {somatorio/notas.Length}");

            char[] letras = { 'A', 'r', 'r', 'a', 'y' };
            string palavra = new string(letras);
            Console.WriteLine(palavra);

        }
    }
}
