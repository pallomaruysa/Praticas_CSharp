using System;

namespace Exercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;


            Console.WriteLine("Digite o primeiro inteiro");
            number1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo inteiro");
            number2 = Int32.Parse(Console.ReadLine());


            if(number1 == number2)
                Console.WriteLine(number1+" == "+number2);

             if (number1 != number2)
                Console.WriteLine(number1+" != "+number2);

             if (number1 < number2)
                Console.WriteLine(number1+" < "+number2);
            
             if (number1 > number2)
                Console.WriteLine(number1+" > "+number2);

             if (number1 <= number2)
                Console.WriteLine(number1+" <= "+number2);

             if (number1 >= number2)
                Console.WriteLine(number1+" >= "+number2);

            //Console.WriteLine("Hello World!");
        }
    }
}


