using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    internal class EstruturaForeach {
        public static void Executar() {
            string palavra = "Michael Soares de Oliveira";

            foreach (char letra in palavra) {
                Console.WriteLine(letra);
            }

            string[] alunos = new String[] {"Michael","Lucas","Antonia","João","Maria","Pedro","José"};

            Console.WriteLine("Os alunos da turma são:");
            foreach (string aluno in alunos) {
                Console.WriteLine(aluno);
            }

        }

    }
}
