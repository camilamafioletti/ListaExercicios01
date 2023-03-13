namespace Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a nota da primeira prova: ");
            float notaUm = float.Parse(Console.ReadLine());

            Console.Write("Digite a nota da segunda prova: ");
            float notaDois = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o peso de cada prova: ");
            Console.WriteLine("Digite o valor da primeira prova: ");
            float pesoUm = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da segunda prova: ");
            float pesoDois = float.Parse(Console.ReadLine());

            float media = (notaUm * pesoUm) + (notaDois * pesoDois);

            Console.WriteLine($"A média ponderada é: {media}");
        }
    }
}