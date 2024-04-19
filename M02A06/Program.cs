namespace M02A06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Entrada de dados
            float n1 = 0;
            float n2 = 0;
            Console.Write("Primeira nota do aluno: ");
            float.TryParse(Console.ReadLine(), out n1);
            Console.Write("Segunda nota do aluno: ");
            float.TryParse(Console.ReadLine(), out n2);

            // Cálculo da média e situacoes
            float média = (n1 + n2) / 2;
            bool sit01 = média >= 0.0 && média < 4.0;
            bool sit02 = média >= 4.0 && média < 7.0;
            bool sit03 = média >= 7.0 && média <= 10.0;

            // Mostrando resultados
            Console.WriteLine($"A média do aluno foi {média:F1}");
            Console.WriteLine($"Aluno está aprovado? {sit03}");
            Console.WriteLine($"Aluno está em Recuperacao? {sit02}");
            Console.WriteLine($"Aluno está Reprovado? {sit01}");
            Console.ReadKey();


        }
    }
}
