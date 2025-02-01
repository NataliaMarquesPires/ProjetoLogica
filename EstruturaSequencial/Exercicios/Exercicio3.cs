using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.EstruturaSequencial.Exercicios {
    internal class Exercicio3 {
        public static void Main1() {
            /*Fazer um programa para ler o nome (apenas uma palavra) e idade de duas
              pessoas. Ao final mostrar uma mensagem com os nomes e a idade entre essas pessoas,
              como uma casa decimal.
             */

            string nome1, nome2;
            int idade1, idade2;
            double media;
            Console.Write("Insira o nome da Primeira Pessoa:");
            nome1 = (Console.ReadLine()).ToString();
            Console.Write($"Insira a idade de {nome1}:");
            idade1 = int.Parse(Console.ReadLine());
            
            Console.Write("Insira o nome e a idade da Segunda Pessoa:");
            nome2 = (Console.ReadLine()).ToString();
            Console.Write($"Insira a idade de {nome2}:");
            idade2 = int.Parse(Console.ReadLine());

            media =(double) (idade1 + idade2) / 2;
            Console.WriteLine($"A idade média de {nome1} e {nome2} é de {media.ToString("F1", CultureInfo.InvariantCulture)} anos");

            Console.ReadLine();
        }

    }
}
