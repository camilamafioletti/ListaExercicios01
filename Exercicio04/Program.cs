namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double inicio, final, consumo;

            Console.Write("Digite a quilometragem(km) inicial: ");
            inicio = double.Parse(Console.ReadLine());

            Console.Write("Digite a quilometragem(km) final: ");
            final = double.Parse(Console.ReadLine());

            Console.Write("Digite o consumo de combustível em litros(l): ");
            consumo = double.Parse(Console.ReadLine());

            double distancia = inicio - final;
            double consumoPorKm = distancia / consumo;

            Console.WriteLine($"O consumo de combustível por km foi de: {consumoPorKm.ToString("F2")} litros/km");
            Console.ReadLine();
        }
    }
}