using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadorTernario {
        public static void Executar() {
            double nota = 7.0;
            bool bomComportamento = true;
            var resultado = nota >= 7.0 && bomComportamento? "Aprovado" 
                : "Reprovado";

            Console.WriteLine(resultado);
            // Verifica a condição e se verdadeira faz o primeiro caso se não o segundo caso.
        }
    }
}
