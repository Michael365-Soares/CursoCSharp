using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class ReadOnly {
        public static void Executar() {

            var cliente1 = new Cliente("Michael Soares",new DateTime(year:1994,month:09,day:16));
            cliente1.ToString();

        }

    }

    public class Cliente {

        public string Nome;
        readonly DateTime Nascimento;
        /*Palavra reservada readonly permite criar uma variável imutável após ter seu valor setado, porém a 
         * mesma permite setar seu valor em tempo de execução do programa
        */

        public Cliente() { }
        public Cliente(string Nome,DateTime Nascimento ) {
            this.Nome = Nome;
            this.Nascimento = Nascimento;
        }

        public string getDataDeNascimento() {
            return String.Format("{0}/{1:D2}/{2}",Nascimento.Day,Nascimento.Month,Nascimento.Year);
        }

        public void ToString() {
            Console.WriteLine($"Cliente: {this.Nome} nascido em {this.getDataDeNascimento()}");
        }

    }

}
