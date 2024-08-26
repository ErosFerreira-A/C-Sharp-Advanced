using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresDeAtribuicao {
        public static void Executar() {
            int a = 10;
            int b = 5;

            // Atribuição simples
            a = b; // a agora é 5
            Console.WriteLine(a);

            // Atribuição adicionada
            a += 2; // a agora é 7 (5 + 2)
            Console.WriteLine(a);

            // Atribuição subtraída
            a -= 3; // a agora é 4 (7 - 3)
            Console.WriteLine(a);

            // Atribuição multiplicada
            a *= 2; // a agora é 8 (4 * 2)
            Console.WriteLine(a);

            // Atribuição dividida
            a /= 4; // a agora é 2 (8 / 4)
            Console.WriteLine(a);

            // Atribuição de módulo
            a %= 2; // a agora é 0 (2 % 2)
            Console.WriteLine(a);

            // Atribuição AND bit a bit
            a = 5; // a é 5 (0101 em binário)
            a &= 3; // a agora é 1 (0101 & 0011 = 0001)
            Console.WriteLine(a);

            // Atribuição OR bit a bit
            a |= 2; // a agora é 3 (0001 | 0010 = 0011)
            Console.WriteLine(a);

            // Atribuição XOR bit a bit
            a ^= 2; // a agora é 1 (0011 ^ 0010 = 0001)
            Console.WriteLine(a);

            // Atribuição de deslocamento à esquerda
            a <<= 1; // a agora é 2 (0001 << 1 = 0010)
            Console.WriteLine(a);

            // Atribuição de deslocamento à direita
            a >>= 1; // a agora é 1 (0010 >> 1 = 0001)
            Console.WriteLine(a);
        }
    }
}
