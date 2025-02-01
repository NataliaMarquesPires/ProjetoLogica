using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.EstruturaComercial.Exercicios {
    class ExtremamenteFacil {

        static void Main1(string[] args) {

            int A, B, X;

            A = Convert.ToInt32(Console.ReadLine());
            B = Convert.ToInt32(Console.ReadLine());

            X = A + B;

            Console.WriteLine($"X = {X}");

            Console.ReadLine();
        }

    }
}
