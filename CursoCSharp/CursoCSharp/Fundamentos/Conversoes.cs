using System;


namespace CursoCSharp.Fundamentos {
    internal class Conversoes {
        public static void Executar() {
            // Sempre que existe a possibilidade de ocorrer perda de informação é necessário informar que desejo converter o dado em outro dado.
            // O compilador anilisa o tipo e não a informação.

            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado); // Conversão Implícita.

            double nota = 9.7;
            int notaTrucada = (int) nota; // Conversão Explicita(Cache).
            Console.WriteLine($"Nota truncada {notaTrucada}");

            // Conversão de string para inteiro
            Console.Write("Digite sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine($"Idade inserida {idadeInteiro}");

            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine($"Resultado: {idadeInteiro}");

            Console.Write("Digite um número:");
            string palavra = Console.ReadLine();
            int numero;
            int.TryParse(palavra, out numero);
            Console.WriteLine($"Resultado: {numero}");// Tenta fazer um Parse e caso não consiga retorna 0
            // É possível declarar dentro do próprio TryParse

            /* int.TryParse(Console.ReadLin(), out int num2);
             *Console.Write($"Resultado: {num2}"); 
             */











        }
    }
}
