using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.EstruturaSequencial.Exercicios {
     class SalarioComBonus {
         static void Main1() {
            /*
             Faça um programa que leia o nome de um vendedor, o seu salário fixo e o total de vendas efetuadas por ele no mês (em dinheiro). 
             Sabendo que este vendedor ganha 15% de comissão sobre suas vendas efetuadas, informar o total a receber no final do mês, 
                com duas casas decimais. O arquivo de entrada contém um texto (primeiro nome do vendedor) e 2 valores de dupla precisão (double) 
                com duas casas decimais, representando o salário fixo do vendedor e montante total das vendas efetuadas por este vendedor.
             Imprima o total que o funcionário deverá receber, conforme exemplo fornecido.*/

            string vendedor;
            double salario, vendas, total;

            Console.WriteLine("Informe as informacoes do vendedor:");
            Console.Write("Nome: ");
            vendedor = Console.ReadLine();
            Console.Write("Salario fixo: ");
            salario = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Valor vendido no mes: ");
            vendas = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            total = (vendas * 0.15) + salario;

            Console.WriteLine("TOTAL = " + total.ToString("f2", CultureInfo.InvariantCulture));
            Console.ReadLine();

        }
    }
}
