using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class GetSet {
        public static void Executar() {
            Moto moto1 = new Moto("Honda","CG 150",160);
            Console.WriteLine("Marca:{0}|Modelo:{1}|Cilindradas:{2}",moto1.getMarca(),moto1.getModelo(),
             moto1.getCilindradas());
        }

        public class Moto {
            private string Marca;
            private string Modelo;
            private uint Cilindradas;

            public Moto(string Marca, string Modelo, uint Cilindradas) {
                this.Marca = Marca;
                this.Modelo = Modelo;
                this.Cilindradas = Cilindradas;
            }

            public Moto() { }

            public string getMarca(){
                return this.Marca;
            }
            public string getModelo() {
                return this.Modelo;
            }
            public uint getCilindradas() {
                return this.Cilindradas;
            }

            public void setMarca(string Marca ){
                this.Marca = Marca;
            }

            public void setModelo(string Modelo) {
                this.Marca = Modelo;
            }

            public void setCilindradas(uint Cilindradas) {
                this.Cilindradas =Cilindradas;
            }

        }

    }
}
