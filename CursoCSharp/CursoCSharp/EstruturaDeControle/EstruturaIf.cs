using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle {
    internal class EstruturaIf {
        public static void Executar() {
            string nome = "Eros";

            //if(nome == "Eros" || nome == "eros"){}
            if(nome.ToLower() == "eros") {
                Console.WriteLine($"Seu nome é Lindo demais");
            } else {
                Console.WriteLine(nome);
            }

        }
    }
}
