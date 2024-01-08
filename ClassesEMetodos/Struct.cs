using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class ExemploStruct {
        public static void Executar() {
            Coordenada coordenadaInicial;
            coordenadaInicial.X=2;
            coordenadaInicial.Y = 2;
            coordenadaInicial.MoverNaDiagonal(5);
            Console.WriteLine($"Coordenada inicial X={coordenadaInicial.X} e Y={coordenadaInicial.Y}");

            var coordenadaFinal = new Coordenada(x:9,y:1);
            coordenadaFinal.MoverNaDiagonal(10);
            Console.WriteLine($"Coordenada final X={coordenadaFinal.X} e Y={coordenadaFinal.Y}");

        }

    }
    interface Ponto {
        void MoverNaDiagonal(int delta);
    }

    struct Coordenada:Ponto {

        public int X;
        public int Y;

        public Coordenada(int x,int y) {
            this.X = x;
            this.Y = y;
        }
        public void MoverNaDiagonal(int delta) {
            this.X += delta;
            this.Y += delta;
        }

    }


}
