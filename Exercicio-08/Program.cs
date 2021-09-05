using System;

namespace Exercicio_08
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNumber1, secondNumber2;

            int  number1, number2, sum;

            Console.WriteLine("Digite o primeiro inteiro");
            firstNumber1 = Console.ReadLine();

            Console.WriteLine("Digite o segundo inteiro");
            secondNumber2 = Console.ReadLine();

            // Conveerter numeros do tipo string para tipo inteiro
            number1 = Int32.Parse(firstNumber1);
            number2 = Int32.Parse(secondNumber2);

            sum = number1 + number2;

            Console.WriteLine("\n A soma é {0}.", sum);

        
        }
    }
}
