using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresUnarios {
        public static void Executar() {
            int numTeste = -10;
            bool forte = true;
            int x = 10;


            Console.WriteLine($"Você é forte ? {!forte}");
            Console.WriteLine(-numTeste);// Inverte o valor positivo ou negativo

            // Incremento

            Console.WriteLine($"Valor inicial de x: {x}");
            Console.WriteLine($"Pré-incremento: {++x}"); // x é incrementado para 11, depois usado
            Console.WriteLine($"Pós-incremento: {x++}"); // x é usado como 11, depois incrementado para 12
            Console.WriteLine($"Valor de x após pós-incremento: {x}");

            // Decremento
            Console.WriteLine($"Pré-decremento: {--x}"); // x é decrementado para 11, depois usado
            Console.WriteLine($"Pós-decremento: {x--}"); // x é usado como 11, depois decrementado para 10
            Console.WriteLine($"Valor de x após pós-decremento: {x}");

            // Complemento bit a bit
            // Necessário mais sobre depois.
            int w = 5; // 0000 0101 em binário
            Console.WriteLine($"Valor de w: {w}");
            Console.WriteLine($"Complemento bit a bit de w: {~w}"); // Complemento bit a bit de 5 (1111 1010 em binário, ou -6)
        }
    }
}
