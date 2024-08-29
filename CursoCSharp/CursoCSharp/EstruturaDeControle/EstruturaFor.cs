using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle {
    internal class EstruturaFor {
        // Melhor usado quando sabemos exatamente a quantidade de vezes que queremos a repetição.
        public static void Executar() {
            Console.WriteLine("Digite o número de vezes que deseja repetir: ");
            int.TryParse(Console.ReadLine(), out int num);
            int contador = num;

            for (int i = 0; i <= num; i++) {
                Console.WriteLine($"{i}°: {contador}");
                contador--;
            }
        }
    }
}
