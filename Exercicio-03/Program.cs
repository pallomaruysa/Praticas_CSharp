using System;

namespace Exercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int ordem=0;
            string a;
            int[] arr2 = new int [10];
               int count = 0;
            while (ordem != 1)
                {
                    a = "ola"+count;
                  count++;
            Console.WriteLine(a);
                Console.WriteLine(count);
                ordem = int.Parse(Console.ReadLine());
                }
        }
    }
}
