namespace Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius = 0;
            double fahrenheit = 0;

            Console.Write("Digite a temperatura em graus Celsius: ");
            celsius = Convert.ToDouble(Console.ReadLine());

            fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine("A temperatura em graus Fahrenheit é: " + fahrenheit.ToString("F2") + "°F.");
        }
    }
}
