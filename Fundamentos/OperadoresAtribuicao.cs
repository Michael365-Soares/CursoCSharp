using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresAtribuicao {
        public static void Executar() {
            int num1 = 3;
            num1 = 7;
            num1 += 10;//num1=num1+10;
            num1 -= 3;
            num1 *= 10;
            num1 /= 2;
            num1 %= 3;
            Console.WriteLine("O valor atual do número é  {0} ",num1);

            //Passagem de valor por cópia(valores literais)
            int num2 = 10;
            int num3 = num2;
            Console.WriteLine("Valores atuais de num2:{0} e num3:{1}",num2,num3);
            num3 += 15;
            Console.WriteLine("Valores atuais de num2:{0} e num3:{1} somando o valor 15 ao num3",num2,num3);

            //Passagem de valor por referência
            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "Michael";
            dynamic d = c;
            Console.WriteLine($"Nome atual do objeto C:{c.nome} e nome atual do objeto D : {d.nome} ");
            Console.WriteLine("Alterando o nome do objeto D...");
            d.nome = "Lucas Ryan";
            Console.WriteLine($"Nome atual do objeto C:{c.nome} e nome atual do objeto D : {d.nome} ");
        }
    }
}
