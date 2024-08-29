using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle {
    internal class EstruturaWhile {
        public static void Executar() {
            // Usada para um contexto para quantidade de repetição indeterminda, até atingir o valor desejado.

            Random random = new Random();
            int numSecreto = random.Next(1, 16);
            Console.WriteLine("Advinhe o número secreto de 1 até 15 !!!");
            int.TryParse(Console.ReadLine(), out int numEscolhido);



            while (numEscolhido != numSecreto) {
                Console.WriteLine("Ainda não é o número, tente novamente !");
                Console.WriteLine($"Número digitado: {numEscolhido}.");


                if (numEscolhido > numSecreto) {
                    Console.WriteLine("O número digitado é maior do quê o número secreto !!!");
                } else {
                    Console.WriteLine("O número digitado é menor do quê o número secreto !!!");
                }
                Console.WriteLine("Digite outro número : ");
                numEscolhido = int.Parse(Console.ReadLine());
            }

            Fim(numSecreto);
        }
        private static void Fim(int numSecreto) {
            var corAnterior = Console.BackgroundColor;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine($"Você acertou o número !!!");
            Console.WriteLine($"Número Secreto: {numSecreto}");
            Console.WriteLine("Fim ! :D");
            Console.BackgroundColor = corAnterior;

        }
    }
}
