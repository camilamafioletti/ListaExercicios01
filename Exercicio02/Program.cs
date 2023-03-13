namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit = 0;
            double celsius = 0;

            Console.WriteLine("Entre com a temperatura em fahrenheit: ");
            fahrenheit = double.Parse(Console.ReadLine());

            celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("Temperatura convertida em celsius: " + celsius.ToString("F2"));
        }
    }
}