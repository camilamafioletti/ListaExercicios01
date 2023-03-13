namespace Exercicio22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Digite o valor de A: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de B: ");
            b = int.Parse(Console.ReadLine());

            if (a == b)
            {
                c = a + b;
                Console.WriteLine("Os valores são iguais. A soma de C é: " +c);
            }
            else
            {
                c = a * b;
                Console.WriteLine("Os valores são diferentes. A multiplicação de C é: " +c);
            }
        }
    }
}