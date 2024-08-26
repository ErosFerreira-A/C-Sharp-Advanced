using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    internal class FormantandoNumero {
        public static void Executar() {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));// Formata para duas casas decimais
            Console.WriteLine(valor.ToString("C"));// Valor monetário
            Console.WriteLine(valor.ToString("P"));// Percentual
            Console.WriteLine(valor.ToString("#.##"));// Formata para valor decimal e arredonda..

            CultureInfo cultura = new CultureInfo("pt-BR");
            Console.WriteLine(valor.ToString("C", cultura));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));// Adiciona caractéres a esquerda até o número chegar a 10° Posição.
        }
    }
}
