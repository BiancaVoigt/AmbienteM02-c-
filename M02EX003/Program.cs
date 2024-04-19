namespace M02EX003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float nota1 = 3f;
            float nota2 = 4f;

            float média = (nota1 + nota2) / 2; //Por os parenbteses para a adicao ser feita primeiro
            Console.WriteLine($"As notas registradas foram {nota1:f1} e {nota2:f1}");
            Console.WriteLine($"A média do aluno foi {média:f1}");
            Console.ReadKey();

            // Sempre Valide, faca a conta no papel para ver se a conta está dando certo!!!


        }
    }
}
