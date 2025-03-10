﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.EstruturaSequencial.Exercicios {
     class Esfera {
        static void Main1() {
            /*Faça um programa que calcule e mostre o volume de uma esfera sendo fornecido o valor de seu raio (R). A fórmula para calcular o 
              volume é: (4/3) * pi * R3. Considere (atribua) para pi o valor 3.14159. Dica: Ao utilizar a fórmula, procure usar (4/3.0) 
              ou (4.0/3), pois algumas linguagens (dentre elas o C++), assumem que o resultado da divisão entre dois inteiros é outro inteiro.
              O arquivo de entrada contém um valor de ponto flutuante (dupla precisão), correspondente ao raio da esfera.A saída deverá ser uma 
              mensagem "VOLUME" conforme o exemplo fornecido abaixo, com um espaço antes e um espaço depois da igualdade. 
              O valor deverá ser apresentado com 3 casas após o ponto.*/

            double pi = 3.14159;
            double raio, volume;

            raio = double.Parse(Console.ReadLine());

            volume = (4 / 3.0) * pi * Math.Pow(raio, 3);

            Console.WriteLine("VOLUME = " + volume.ToString("f3", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
