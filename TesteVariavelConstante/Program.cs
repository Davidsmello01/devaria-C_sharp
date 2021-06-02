using System;

namespace TesteVariavelConstante
{
    class Program
    {
        static void Main(string[] argumentos)
        {
            const string constante = "uma constante que não muda";

            if (argumentos.Length == 0)
            {
                Console.WriteLine("Favor informar numero inteiro");
                return;
            }
            int inteiro;
            bool test = int.TryParse(argumentos[0], out inteiro);

            if (test == false)
            {
                Console.WriteLine("O argumrnto informado não é um numero inteiro");
                return;
            }

            Console.WriteLine(constante);
            Console.WriteLine("O numero informado foi: " + inteiro);
        }
    }
}
