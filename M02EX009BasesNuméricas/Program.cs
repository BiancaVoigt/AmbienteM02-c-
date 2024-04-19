namespace M02EX009BasesNuméricas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 25;

            Console.WriteLine($"O número {n} corresponde a {Convert.ToString(n, toBase:2)} em binário");
            Console.WriteLine($"O número {n} corresponde a {Convert.ToString(n, toBase :8)} em octal");
            Console.WriteLine($"O número {n} corresponde a {Convert.ToString(n, toBase: 16)} em Hexadecimal");
            


            Console.ReadKey();
        }
    }
}
