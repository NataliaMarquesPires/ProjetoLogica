using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.EstruturaComercial.Exercicios {
    class Media2 {

        static void Main1(string[] args) {
            /*Leia 3 valores, no caso, variáveis A, B e C, que são as três notas de um aluno. A seguir, calcule a média do aluno, 
             * sabendo que a nota A tem peso 2, a nota B tem peso 3 e a nota C tem peso 5. Considere que cada nota pode ir de 0 até 10.0, 
             * sempre com uma casa decimal.
                Entrada: O arquivo de entrada contém 3 valores com uma casa decimal, de dupla precisão (double).
                Saída: Imprima a mensagem "MEDIA" e a média do aluno conforme exemplo abaixo, com 1 dígito após o ponto decimal e 
                com um espaço em branco antes e depois da igualdade.
             */

            double A, B, C, MEDIA;

            A = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            C = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            MEDIA = ((A * 2) + (B * 3) + (C * 5)) / 10;

            Console.WriteLine("MEDIA = " + MEDIA.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
