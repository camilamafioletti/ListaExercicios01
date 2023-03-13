namespace Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a largura do terreno em m:");
            double largura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o comprimento do terreno em m:");
            double comprimento = double.Parse(Console.ReadLine());

            double area = largura * comprimento;

            Console.WriteLine("A área do terreno é de " + area + " metros quadrados.");
        }
    }
}