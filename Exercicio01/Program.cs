namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double comprimento, largura, altura, volume;

            Console.Write("Digite o comprimento da caixa em metros: ");
            comprimento = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a largura da caixa em metros: ");
            largura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a altura da caixa em metros: ");
            altura = Convert.ToDouble(Console.ReadLine());

            volume = comprimento * largura * altura;

            Console.WriteLine("O volume da caixa é: " + volume + " metros cúbicos.");
        }
    }
}