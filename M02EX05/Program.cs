namespace M02EX05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool p = true;
            bool q = false;

            Console.WriteLine($"nao {p} = {!p}");  // Operador Lógico NAO
            Console.WriteLine($"{p} e {q} = {p && q}"); // Operador lógico E
            Console.WriteLine($"{p} ou {q} = {p || q}"); // Operador Lógico OU


        }
    }
}
