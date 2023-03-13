namespace Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double paes, broas, total;

            Console.WriteLine("Digite a quantidade de paes que foram vendidos: ");
            paes = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de paes que foram vendidos: ");
            broas = double.Parse(Console.ReadLine());

            double valorPao = paes * 0.12;
            double valorBroa = broas * 1.50;
            double totalArrecadado = valorPao + valorBroa;
            double valorPoupanca = totalArrecadado * 0.1;

            Console.WriteLine($"Valor arrecadado com a venda de pães e broas: R${totalArrecadado:F2}");
            Console.WriteLine($"Valor a ser guardado na conta de poupança: R${valorPoupanca:F2}");
        }
    }
}