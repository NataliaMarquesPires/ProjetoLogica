using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.EstruturaComercial.Exercicios {
    class Media1 {
        static void Main1(string[] args) {
            /*Leia 2 valores de ponto flutuante de dupla precisão A e B, que correspondem a 2 notas de um aluno. 
             * A seguir, calcule a média do aluno, sabendo que a nota A tem peso 3.5 e a nota B tem peso 7.5 (A soma dos pesos portanto é 11).
             * Assuma que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.
               Entrada: O arquivo de entrada contém 2 valores com uma casa decimal cada um.
               Saída: Imprima a mensagem "MEDIA" e a média do aluno conforme exemplo abaixo, com 5 dígitos após o ponto decimal e com um 
               espaço em branco antes e depois da igualdade.*/

            double A, B, MEDIA;

            A = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            MEDIA = ((A * 3.5) + (B * 7.5)) / 11;

            Console.WriteLine("MEDIA = " + MEDIA.ToString("F5", CultureInfo.InvariantCulture));
        }
    }
}
