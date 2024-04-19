namespace M02EX005B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nasc = 0;
            
            Console.WriteLine("IDADE PARA VOTAR");
            Console.WriteLine("-------------------------------");
            Console.Write("Digite o ano de seu nascimento: ");
            int.TryParse(Console.ReadLine(), out nasc);

            int atual = DateTime.Now.Year;
            int id = atual - nasc;
            
            Console.WriteLine($"Eleitor, a sua idade é de {id} anos.");

            bool imp = id < 16;
            bool opc = id >= 16 && id < 18 || id >= 65;
            bool obg = id >= 18 && id <= 65;

            Console.WriteLine($"O eleitor é obrigado a votar? {obg} ");
            Console.WriteLine($"O eleitor tem voto opcional? {opc}");
            Console.WriteLine($"O eleitor está impossibilitado de votar? {imp}");
            Console.ReadKey();



        }
    }
}
