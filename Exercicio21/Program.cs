namespace Exercicio21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, resultado;

            Console.Write("Escreva o valor de A: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Escreva o valor de B: ");
            b = int.Parse(Console.ReadLine());

            if (a == b)
            {
                resultado = a + b;
                Console.WriteLine("Os valores são iguais. A soma é: " +resultado);
            }
            else
            {
                resultado = a * b;
                Console.WriteLine("Valores diferentes. A multiplicação é: " +resultado);
            }

        }
    }
}