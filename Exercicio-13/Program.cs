using System;
using System.Collections;

namespace Exercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myNumbers = {10, 20, 30, 40, 50};

            for(int i=0; i<myNumbers.Length; i++){
                Console.WriteLine(myNumbers[i]);
            }
            
            Console.WriteLine();
//-----------------------------------------------------------------------
            ArrayList list = new ArrayList();
            list.Add("Welcome");
            list.Add("Moon");        
            list.Add(2.443); 
            list.Add(7);
            list.Add('F');
            list.Add('M');
            list.Add(DateTime.Now);
            list.Remove('M'); // remove o valor
            list.RemoveAt(2); // remove o valor do index (x)
            list.Insert(0, "Hii");
            //list.RemoveRange(0,5); -> remove em sequencia

            for(int i=0; i< list.Count; i++){
                object value = list[i];
                Console.WriteLine("Index= {0}; Value= {1}", i, value);
            } 
            Console.WriteLine();
//-----------------------------------------------------------------------
            Console.WriteLine("Com For Each");

            ArrayList list2 = new ArrayList();
            list2.Add("Quarto");
            list2.Add("Banheiro");
            list2.Add("Cozinha");
            list2.Add("Quintal");
            list2.Add(23);
            list2.Remove(23);
            list2.Insert(0, "Varanda");
            list.RemoveRange(0,2);

            //metodo para colocar em ordem
            list2.Sort();

            foreach (String value in list2) //tipado
            {
                Console.WriteLine(value);
            }
            Console.WriteLine();

            //metodo para colocar em ordem inversa
            list2.Reverse();

            foreach (object value in list2) //tipado
            {
                Console.WriteLine(value);
            }
            Console.WriteLine();

            

            Console.WriteLine();
        }
    }
}
