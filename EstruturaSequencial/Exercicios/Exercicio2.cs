using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.EstruturaSequencial.Exercicios {
    class Exercicio2 {
        static void Main1() {
            /*Faça um programa para ler as medidas da base e altura de um retangulo. Em seguida, mostrar o valor da área, perimetro
              e diagonal deste retângulo, com quatro casas decimais.
             */
            double altura, comprimento, area, perimetro, diagonal;
            Console.Write("Insira o valor da altura: ");
            altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Insira o valor da base: ");
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = altura * comprimento;
            perimetro = (altura * comprimento) * 2;
            diagonal = Math.Sqrt(Math.Pow(altura, 2) + Math.Pow(comprimento, 2));

            Console.WriteLine("Area = " + area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro = " + perimetro.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area = " + diagonal.ToString("F4", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
