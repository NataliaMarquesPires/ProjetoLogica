using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.EstruturaComercial.Exercicios {
    class Consumo {
        static void Main1(string[] args) {
            /*Calcule o consumo médio de um automóvel sendo fornecidos a 
              distância total percorrida (em Km) e o total de combustível gasto (em litros).
              Entrada: O arquivo de entrada contém dois valores: um valor inteiro X representando a distância total percorrida (em Km), 
              e um valor real Y representando o total de combustível gasto, com um dígito após o ponto decimal.
              Saída: Apresente o valor que representa o consumo médio do automóvel com 3 casas após a vírgula, seguido da mensagem "km/l".*/

            int X;
            double Y, km;

            X = Convert.ToInt32(Console.ReadLine());
            Y = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            km = X / Y;

            Console.WriteLine(km.ToString("F3", CultureInfo.InvariantCulture) + " km/l");

        }
    }
}
