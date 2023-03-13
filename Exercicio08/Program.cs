namespace Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double altura, raio, volume;

            Console.WriteLine("Digite a altura da lata em cm: ");
            altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o raio da lata em cm: ");
            raio = double.Parse(Console.ReadLine());

            volume = Math.PI * raio * raio * altura;

            Console.WriteLine($"O volume da lata é {volume:F2} centímetros cúbicos.");
        }
    }
}