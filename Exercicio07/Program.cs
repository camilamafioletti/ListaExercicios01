namespace Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salarioBase, totalVendas, comissao, salarioTotal;

            Console.Write("Digite o salário do vendedor: ");
            salarioBase = double.Parse(Console.ReadLine());

            Console.Write("Digite o total de vendas do vendedor: ");
            totalVendas = double.Parse(Console.ReadLine());

            Console.Write("Digite a comissão a ser aplicada sobre as vendas (em %): ");
            comissao = double.Parse(Console.ReadLine());

            salarioTotal = salarioBase + (totalVendas * (comissao * salarioBase / 100));

            Console.WriteLine("O salário total do vendedor é: R$ {0:N2}", +salarioTotal);
        }
    }
}