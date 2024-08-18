using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class VariaveisEConstantes {

        public static void Executar() {
            double raio = 5.5;
            const double PI = 3.14;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine($"O valor da Área é {area}");

            bool estaChovendo = false;
            Console.WriteLine($"Está chovendo ? {estaChovendo}");

            byte idade = 45;
            Console.WriteLine("Idade: ", idade);

            //sbyte - Quando for utilizar números negativos e for necessário utilizar o byte.

            short salario = short.MaxValue;
            Console.WriteLine("Salário: " + salario);

            // int - Valores inteiros, geralmente é o mais utilizado quando trata-se de números.

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor long: " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine($"População Mundial: {populacaoMundial}");

            float precoComputador = 2500.99F;
            Console.WriteLine($"Preco do Computador: {precoComputador}");

            // decimal - é utilzado para quando necessitamos de valores astrônomicos

            // acessar ou armazenar uma letra usa-se o char

            // string - cadeia de caractéres.

            string mensagem = "Obrigado por olhar meu códigos 😁";
            Console.WriteLine(mensagem);
        }
    }
}
