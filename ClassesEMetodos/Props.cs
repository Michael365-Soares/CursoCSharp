using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class Props {
        public static void Executar() {

            CarroOpcional c1 = new CarroOpcional();
            c1.Nome = "HONDA CIVIC";
            c1.Preco =80000.00;
            Console.WriteLine("O {0} custa o valor de R${1}",c1.Nome,c1.PrecoComDesconto);

            CarroOpcional c2 = new CarroOpcional("HIUNDAY HB20", 60000.00);
            Console.WriteLine("O {0} custa o valor de R${1}", c2.Nome, c2.PrecoComDesconto);

        }

    }

    public class CarroOpcional {

        double desconto = 0.1;
        string nome;
        public string Nome
        {
            get
            {
                return "Opcional: " + this.nome;
            }
            set
            {
                this.nome = value;
            }
        }

        //Propriedades autoimplementadas
        //public double Preco{get; set;}
        double preco;
        public double Preco {
            get {
                return preco;
            }
            set {
                preco=value * 3;
            } 
        }

        public double PrecoComDesconto{
            get => this.Preco - (this.Preco * this.desconto);
        }

        public CarroOpcional(string Nome, double Preco ) {
            this.Nome = Nome;
            this.Preco = Preco;
        }

        public CarroOpcional() {}

    }

}
