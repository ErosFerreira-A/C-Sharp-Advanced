﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class NotacaoPonto {
        public static void Executar() {
            var saudacao = "Olá, Mundo !".Insert(10, " estou aprendendo");
            Console.WriteLine(saudacao);
        }
    }
}
