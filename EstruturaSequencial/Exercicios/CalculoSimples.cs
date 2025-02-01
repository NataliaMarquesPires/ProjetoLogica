using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.EstruturaComercial.Exercicios {
    class CalculoSimples {
        
        static void Main1(string[] args) {
            /*Neste problema, deve-se ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o código de uma peça 2, 
              o número de peças 2 e o valor unitário de cada peça 2. Após, calcule e mostre o valor a ser pago.
              Entrada: O arquivo de entrada contém duas linhas de dados. Em cada linha haverá 3 valores, 
              respectivamente dois inteiros e um valor com 2 casas decimais.
              Saída: A saída deverá ser uma mensagem conforme o exemplo fornecido abaixo, 
              embrando de deixar um espaço após os dois pontos e um espaço após o "R$". O valor deverá ser apresentado com 2 casas após o ponto.*/

            int codPeca1, codPeca2, numPeca1, numPeca2;
            double valorPeca1, valorPeca2, total;

            string[] valores = Console.ReadLine().Split(' ');
            codPeca1 = int.Parse(valores[0]);
            numPeca1 = int.Parse(valores[1]);
            valorPeca1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            valores = Console.ReadLine().Split(' ');
            codPeca2 = int.Parse(valores[0]);
            numPeca2 = int.Parse(valores[1]);
            valorPeca2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            total = (valorPeca1 * numPeca1) + (valorPeca2 * numPeca2);

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
