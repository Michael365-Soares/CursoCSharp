using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresLogicos {
        /*
         * Existem dois trabalhos a serem finalizados trabalho01 e trabalho02
         * Se o trabalho01 e tranalho 02 forem concretizados a família compra a televião de 50 polegadas
         * Se a penas um dos trabalhos for concluído a família irá comprar uma televisão de 32 polegadas
         * Se a família comprar qualquer um dos televisores eles irão tomar sorvete
         */
        public static void Executar() {

            Console.WriteLine("O primeiro trabalho foi executado?(S/N)");
            string entrada=Console.ReadLine();
            var executouTrabalho01 = entrada.ToUpper().Equals("S")?true:false;
            Console.WriteLine();
            Console.WriteLine("O segundo trabalho foi executado?(S/N)");
            entrada = Console.ReadLine();
            var executouTrabalho02 = entrada.ToUpper().Equals("S") ? true : false;

            if (executouTrabalho01 && executouTrabalho02) {
                Console.WriteLine("A família comprou a TV de 50 polegadas e tomou sorvete.");
            } else if (executouTrabalho01 ^ executouTrabalho02) {
                Console.WriteLine("A família comprou a TV de 32 polegadas e tomou sorvete.");
            } else{
                Console.WriteLine("A família não comprou nenhuma televisão e nem tomou sorvete.");
            }

        }
    }
}
