namespace M02EX002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int n1 = 5;  // para divisao inteira, 2 números inteiros
            int n2 = 2;

            int res = n1 / n2;
            Console.WriteLine($"O resultado de {n1} ÷ {n2} = {res}");
            Console.ReadKey();
            */

            // para divisao real basta que um operando seja float, decimal
            
            /*
            float n1 = 5;
            int n2 = 2;

            float res = n1 / n2;
            
            Console.WriteLine($"O resultado de {n1} ÷ {n2} = {res:f1}");
            float.TryParse(Console.ReadLine(), out res);
            Console.ReadKey();
            */

            // Ou faca dois Casting , deixe os 2 numeros int e na resposta faca o Casting de n1 e n2
            // float res = (float) n1 / (float) n2;
            int n1 = 0;
            int n2 = 0;

            Console.Write("Numerador: ");
            int.TryParse(Console.ReadLine(), out n1);
            Console.Write("Denominador: ");
            int.TryParse(Console.ReadLine(), out n2);
            
            Console.WriteLine($"Divisao Inteira {n1} ÷ {n2} = {(int) n1 / (int) n2:D}");
            Console.WriteLine($"Divisao Real {n1} ÷ {n2} = {(float)n1 / (float)n2:f1}");
            Console.ReadKey();
        }
    }
}
