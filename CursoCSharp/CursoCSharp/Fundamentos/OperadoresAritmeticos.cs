using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresAritmeticos {
        public static void Executar() {
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - total * desconto;
            Console.WriteLine($"O preço final é {totalComDesconto}");

            // Detecar se o númeroo é par ou ímpar

            Console.Write("Digite um número: ");
            var numPalavra = Console.ReadLine();
            int num = Convert.ToInt32( numPalavra );

            Console.WriteLine("{0}/2 tem resto {1}", num, num % 2);

            if (num % 2 == 0) {
                Console.WriteLine($"O número {num} é par");
            } else {
                Console.WriteLine($"O número {num} é Ímpar");
            }



        }
    }
}
