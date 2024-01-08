using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class ExemploEnum {
        public static void Executar() {
            int id = (int)Genero.Animacao;
            Console.WriteLine(id);

            var filmeParaFamilia = new Filme();
            filmeParaFamilia.Titulo = "As Crônicas de Nárnia";
            filmeParaFamilia.GeneroDoFilme =Genero.Aventura;
            Console.WriteLine($"O filme {filmeParaFamilia.Titulo} é do genêro {filmeParaFamilia.GeneroDoFilme}");

        }

    }

    public enum Genero{ Acao,Aventura,Terror,Animacao,Comedia}

    public class Filme {
        public string Titulo { get; set; }
        public Genero GeneroDoFilme { get; set; }

    }

}
