using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.EstruturaComercial.Exercicios {
    class Diferenca {
        static void Main1(string[] args) {
            /*Leia quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto de A e B 
             * pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).
            Entrada: O arquivo de entrada contém 4 valores inteiros.
            Saída: Imprima a mensagem DIFERENCA com todas as letras maiúsculas, conforme exemplo abaixo, 
            com um espaço em branco antes e depois da igualdade.*/

            int A, B, C, D, DIFERENCA;

            A = Convert.ToInt32(Console.ReadLine());
            B = Convert.ToInt32(Console.ReadLine());
            C = Convert.ToInt32(Console.ReadLine());
            D = Convert.ToInt32(Console.ReadLine());

            DIFERENCA = ((A * B) - (C * D));

            Console.WriteLine("DIFERENCA = " + DIFERENCA);
        }
    }
}
