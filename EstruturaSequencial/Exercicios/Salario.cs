using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.EstruturaComercial.Exercicios {
    class Salario {
        static void Main1(string[] args) {
            /*Escreva um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por hora e 
              calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas decimais.
              Entrada: O arquivo de entrada contém 2 números inteiros e 1 número com duas casas decimais, representando o número, quantidade
              de horas trabalhadas e o valor que o funcionário recebe por hora trabalhada, respectivamente.
              Saída: Imprima o número e o salário do funcionário, conforme exemplo fornecido, com um espaço em branco antes e depois 
              da igualdade. No caso do salário, também deve haver um espaço em branco após o $.*/

            int numeroFuncionario, horasTrabalho;
            double salario;

            numeroFuncionario = Convert.ToInt32(Console.ReadLine());
            horasTrabalho = Convert.ToInt32(Console.ReadLine());
            salario = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NUMBER = " + numeroFuncionario);
            Console.WriteLine("SALARY = U$ " + (salario * horasTrabalho).ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
