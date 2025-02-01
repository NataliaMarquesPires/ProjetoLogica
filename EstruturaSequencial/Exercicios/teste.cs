using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.EstruturaComercial.Exercicios {
    class teste {
        struct Peca {
            public string Codigo;
            public int Quantidade;
            public double ValorUnitario;
        }
        static void Main1(string[] args) {
            // Declaração das variáveis
            Peca peca1, peca2;
            double valorTotal;

            // Leitura dos dados de entrada
            Console.WriteLine("Insira os dados da peça 1:");
            Console.Write("Codigo: ");
            peca1.Codigo = Console.ReadLine();
            Console.Write("Quantidade: ");
            peca1.Quantidade = int.Parse(Console.ReadLine());
            Console.Write("Valor unitário: R$ ");
            peca1.ValorUnitario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\nInsira os dados da peça 2:");
            Console.Write("Codigo: ");
            peca2.Codigo = Console.ReadLine();
            Console.Write("Quantidade: ");
            peca2.Quantidade = int.Parse(Console.ReadLine());
            Console.Write("Valor unitário: R$ ");
            peca2.ValorUnitario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Cálculo do valor total
            valorTotal = CalcularValorTotal(peca1, peca2);

            // Exibição do valor a ser pago
            Console.WriteLine("Valor a ser pago: R$ " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
        }

        // Função para calcular o valor total a ser pago
        static double CalcularValorTotal(Peca peca1, Peca peca2) {
            return (peca1.Quantidade * peca1.ValorUnitario) + (peca2.Quantidade * peca2.ValorUnitario);
        }
    }
}
