using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresLogicos {
        public static void Executar() {
            bool a = true;
            bool b = false;

            // AND lógico
            Console.WriteLine(a && b); // false

            // OR lógico
            Console.WriteLine(a || b); // true

            // NOT lógico
            Console.WriteLine(!a); // false

            // AND lógico bit a bit
            Console.WriteLine(a & b); // false

            // OR lógico bit a bit
            Console.WriteLine(a | b); // true

            // XOR lógico bit a bit
            Console.WriteLine(a ^ b); // true
        }
    }
}
