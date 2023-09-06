using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    public class NotacaoPonto {
        public static void Executar() {
            var saudacao = "Olá".ToUpper().Insert(3," world").Replace("world","Mundo!");
            Console.WriteLine(saudacao);


            string valorVazio = null;
            //A notacação ? servi para validar se o objeto que estar chamando a propriedade é diferente de nulo
            // pois se o mesmo por nulo a chamada do atributo/método não é executada
            Console.WriteLine(valorVazio?.Length);
        }
    }
}
