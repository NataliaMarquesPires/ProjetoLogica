using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.EstruturaSequencial.Exercicios {
    class Area {
        public static void Main() {
            /* Escreva um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre:
                a) a área do triângulo retângulo que tem A por base e C por altura.
                b) a área do círculo de raio C. (pi = 3.14159)
                c) a área do trapézio que tem A e B por bases e C por altura.
                d) a área do quadrado que tem lado B.
                e) a área do retângulo que tem lados A e B.
            Entrada O arquivo de entrada contém três valores com um dígito após o ponto decimal.
            Saída O arquivo de saída deverá conter 5 linhas de dados. Cada linha corresponde a uma das áreas descritas acima, sempre com 
                    mensagem correspondente e um espaço entre os dois pontos e o valor. O valor calculado deve ser apresentado com 3 dígitos após o ponto decimal.
             */

            double A, B, C, areaTriangulo, areaCirculo, areaTrapezio, areaQuadrado, areaRetangulo;
            double pi = 3.14159;
            Console.Write("Digite o valor de A:");
            A = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o valor de B:");
            B = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o valor de C:");
            C = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            areaTriangulo = A * C / 2.0;
            areaCirculo = pi * C * C;
            areaTrapezio = A + B / 2.0 * C;
            areaQuadrado = B * B;
            areaRetangulo = A * B;

            Console.WriteLine("Area Triangulo = " + areaTriangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Area Circulo = " + areaCirculo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Area Trapezio = " + areaTrapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Area Quadrado = " + areaQuadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Area Retangulo = " + areaRetangulo.ToString("F3", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
