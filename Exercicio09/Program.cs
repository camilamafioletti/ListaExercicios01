namespace Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double notas;
            double somaInversosNotas = 0;
            double mediaHarmonica;

            Console.Write("Número de notas do aluno: ");
            notas = int.Parse(Console.ReadLine());

            for (int i = 1; i <= notas; i++)
            {
                Console.Write($"Digite a nota {i}: ");
                double nota = double.Parse(Console.ReadLine());
                somaInversosNotas += 1.0 / nota;
            }

            mediaHarmonica = notas / somaInversosNotas;

            Console.WriteLine($"A média harmônica das notas é: {mediaHarmonica:F2}");
        }
    }
}