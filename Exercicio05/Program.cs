﻿using System.Globalization;

namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o valor do raio (r): ");

            double R = double.Parse(Console.ReadLine());
            double pi = Math.PI;
            double RaioCubo = Math.Pow(R, 3);
            double volume = (4.0 / 3) * pi * RaioCubo;

            Console.WriteLine("Volume = " + volume.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}