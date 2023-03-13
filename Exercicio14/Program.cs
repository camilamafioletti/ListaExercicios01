namespace Exercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escreva seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Escreva sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            int diasDeVida = idade * 365;

            Console.WriteLine($"{nome} você já viveu {diasDeVida} dias.");
        }
    }
}