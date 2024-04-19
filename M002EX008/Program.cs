namespace M002EX008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Entrada de dados
            int num = 0;
            Console.Write("Digite um número: ");
            int.TryParse(Console.ReadLine(), out num);

            string tipo = num % 2 == 0 ? "PAR" : "ÍMPAR";
            Console.WriteLine($"O número {num:D} que voce digitou é {tipo}!");
            // Se o Resto da divisao do número divido por 2 = 0 ( num % 2 == 0)
            Console.ReadKey();

        }
    }
}
