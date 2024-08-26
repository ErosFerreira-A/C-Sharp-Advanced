using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresRelacionais {
        public static void Executar() {
            // == , > ,<, !=, >=, <=
            // Os operadores relacionais em C# são utilizados para comparar valores. Eles retornam um valor booleano (true ou false) dependendo da relação entre os operandos. Aqui está uma lista dos operadores relacionais disponíveis em C#:

            int a = 5;
            int b = 10;

            // Igual a
            Console.WriteLine(a == b); // false

            // Diferente de
            Console.WriteLine(a != b); // true

            // Maior que
            Console.WriteLine(b > a); // true

            // Menor que
            Console.WriteLine(a < b); // true

            // Maior ou igual a
            Console.WriteLine(b >= a); // true

            // Menor ou igual a
            Console.WriteLine(a <= b); // true
        }
    }
}
