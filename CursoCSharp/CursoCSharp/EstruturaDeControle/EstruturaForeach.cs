using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle {
    internal class EstruturaForeach {
        public static void Executar() {
            var palavra = "A beleza está nos olhos de quem vê !";

            foreach (var letra in palavra) {
                Console.Write(letra);
            }
            Console.Write(" - (Platão – Atenas, 427-347 a.C.)");
            Console.WriteLine();

            // break tem que estar associado ao switch ou a um laço de repetição.
            // Pecorre do primeiro ao último elemento, muito usado comlista e array.

            Console.WriteLine("Digite o valor final para impressão dos números para desejado: ");
            int.TryParse(Console.ReadLine(), out int num);


            //Retorna números pares
            for (int i = 1; i <= num; i++) {
                if(i % 2 == 1) {
                    continue;
                }
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}
