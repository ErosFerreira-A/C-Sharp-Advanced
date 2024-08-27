using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle {
    internal class EstruturaIfElse {
        public static void Executar() {
            double nota = 7.0;

            // if , else if , else
            if (nota == 10) {
                Console.WriteLine("Nota Perfeita !!!S");
            } else if (nota >= 7.0) {
                Console.WriteLine("Aprovado");
                Console.WriteLine("Muito bem! Continue assim !!!");
            } else {
                Console.WriteLine($"Reprovado: \n Nota: {nota}");
            }
        }
    }
}
