using System;
using System.Globalization;

namespace Exercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            double ladoA, ladoB, ladoC;
            
            Paralelepipedo p1 = new Paralelepipedo();

            Console.WriteLine("Digite o lado A do Paralelepípedo");
            ladoA = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o lado B do Paralelepípedo");
            ladoB = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o lado C do Paralelepípedo");
            ladoC = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            double volume = ladoA * ladoB * ladoC;

            Console.WriteLine("O volume desse paralelpípedo é: "+volume.ToString("F2", CultureInfo.InvariantCulture)+" cm³"); 
        }
    }
}


