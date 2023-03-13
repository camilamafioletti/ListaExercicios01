namespace Exercicio26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int fatorial = 0;

            Console.Write("Digite um número para calcular fatorial: ");
            numero = int.Parse(Console.ReadLine());

            Console.Write($"{numero}! = ");

            for (int i = numero; i >= 1; i--)
            {
                Console.Write($"{i}");
                fatorial *= i;
                if (i > 1)
                {
                    Console.Write(" X ");
                }
            }
            Console.Write(" = " +fatorial);
        }
    }
}