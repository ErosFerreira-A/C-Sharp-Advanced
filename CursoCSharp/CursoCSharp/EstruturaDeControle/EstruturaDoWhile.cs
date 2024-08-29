using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle {
    internal class EstruturaDoWhile {
        // Pelo menos uma vez será executado.
        public static void Executar() {

            string entrada;

            do {
                Console.WriteLine("Digite seu nome:");
                string nome = Console.ReadLine();
                
                Console.WriteLine("Deseja escrever outro nome ? Sim/Não ");
                entrada = Console.ReadLine();
            } while (entrada.ToLower() == "sim");

            
        }
    }
}
