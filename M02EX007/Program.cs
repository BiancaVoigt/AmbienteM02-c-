namespace M02EX007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Entrada de dados
            float altura = 0f;
            Console.Write(" Qual é a sua altura em metros? ");
            float.TryParse(Console.ReadLine(), out altura);
            // Verificacao de Status
            string status = (altura <= 1.70) ? "baixa" : "alta"; // se a altura for menor q 1,70 baixa : (se nao) alta
            // Mostrar resultado
            Console.WriteLine($"Alguém com {altura:F2}m de altura é considerado uma pessoa {status}!");
            Console.ReadKey();

        }
    }
}
