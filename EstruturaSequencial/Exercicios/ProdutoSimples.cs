using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.EstruturaComercial.Exercicios {
     class ProdutoSimples {
        static void Main1(string[] args) {
            /*Leia dois valores inteiros. A seguir, calcule o produto entre estes dois valores e atribua esta operação à variável PROD. 
             * A seguir mostre a variável PROD com mensagem correspondente.   
            Entrada:O arquivo de entrada contém 2 valores inteiros.
            Saída:Imprima a mensagem "PROD" e a variável PROD conforme exemplo abaixo, com um espaço em branco antes e depois da igualdade.*/

            int valor1, valor2, PROD;

            valor1 = Convert.ToInt32(Console.ReadLine());
            valor2 = Convert.ToInt32(Console.ReadLine());

            PROD = valor1 * valor2;

            Console.WriteLine("PROD = " + PROD);
        }
    }
}
