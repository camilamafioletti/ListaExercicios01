﻿namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio, altura, volume;

            Console.Write("Digite o raio da base do cilindro em metros: ");
            raio = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a altura do cilindro em metros: ");
            altura = Convert.ToDouble(Console.ReadLine());

            volume = Math.PI * Math.Pow(raio, 2) * altura;

            Console.WriteLine("O volume do cilindro é: " + volume + " metros cúbicos.");
        }
    }
}