namespace M02EX001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exemplo de operadores aritméticos

            int op1 = 0;
            int op2 = 0;

            // Entradas de dados
            Console.Write("Digite o primeiro operando: ");
            int.TryParse(Console.ReadLine(), out op1);
            Console.Write("Digite o segundo operando: ");
            int.TryParse(Console.ReadLine(), out op2);

            // Realizando as operacoes
            Console.WriteLine($"Calculando +{op1} = {+ op1} "); // Operador de identidade
            Console.WriteLine($"Calculando -{op1} = {- op1} "); //Operador de negacao aritmética
            Console.WriteLine($"Calculando {op1} + {op2} = {op1 + op2}"); // Adicao
            // ou ao invés de criar essa expressao, crie a variavel : int soma = op1 + op2 e no comando ponha ($"Calculando {op1} + {op2} = {soma}")
            Console.WriteLine($"Calculando {op1} - {op2} = {op1 - op2}"); // subtracao
            Console.WriteLine($"Calculando {op1} x {op2} = {op1 * op2}"); // Multiplicacao
            Console.WriteLine($"Calculando {op1} ÷ {op2} = {(float) op1 / (float) op2:f1} **Divisao Real**"); // Divisao Real
            Console.WriteLine($"Calculando {op1} ÷ {op2} = {op1 / op2} **Divisao Inteira**"); // Deu a divisao inteira, já vamos ver a divisao Real que será 2,5
            Console.WriteLine($"Calculando {op1} resto {op2} = {op1 % op2}"); // Remainder, Resto da divisao inteira

            Console.ReadKey();

        }
    }
}
