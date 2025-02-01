using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.EstruturaComercial.Exercicios {
    class AreaCirculo {

        static void Main1() {

            double pi = 3.14159; // Posso tbm utilizar o Math.PI para ter acesso ao valor de PI
            double raio, area;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // Posso utilizar o Convert.ToInt32().

            area = pi * Math.Pow(raio, 2);

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
