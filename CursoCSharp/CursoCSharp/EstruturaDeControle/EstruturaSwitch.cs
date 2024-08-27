using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle {
    internal class EstruturaSwitch {
        public static void Executar() {
            Console.WriteLine("Avalie o meu atendimento com uma nota de 1 a 5:");
            int.TryParse(Console.ReadLine(), out int nota);

            switch (nota) {
                case 1:
                    Console.WriteLine(":( :( Iremos melhorar nosso atendimento para melhor atender você");
                    break;
                case 2:
                    Console.WriteLine(":( :( Iremos melhorar nosso atendimento para melhor atender você");
                    break;
                case 3:
                    Console.WriteLine("Agradecemos sua avaliação, estamos aqui para ajudar");
                    break;
                case 4:
                    Console.WriteLine("Obrigado pela confiança !");
                    break;
                case 5:
                    Console.WriteLine("Volte sempre !!! \n Obrigado por fazer parte da nossa FAMÍLIA !!! ");
                    break;
                default:
                    Console.WriteLine("404 Not Found");
                    break;
            }
        }
    }
}
