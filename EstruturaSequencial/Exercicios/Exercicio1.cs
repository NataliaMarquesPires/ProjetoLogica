using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.EstruturaComercial.Exercicios {
    class Exercicio1 {
        
         static void Main1(string[] args) {
            //Minha Forma 
            //double largura = 10.0;
            //double comprimento = 30.0;
            //double precoMetroQuadrado = 200.0;

            //double area = largura * comprimento;
            //double preco = area * precoMetroQuadrado;

            //Console.WriteLine($"Area = {area}");
            //Console.WriteLine($"Preco = {preco}");

            //Forma do curso
            double largura, comprimento, precoMetroQuadrado, area, preco;

            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            precoMetroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            area = largura * comprimento;
            preco = area * precoMetroQuadrado;

            Console.WriteLine("Area = " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Preco = " + preco.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();

        }

    }
}
