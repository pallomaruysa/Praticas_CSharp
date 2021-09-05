using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            TypeVehicle type = TypeVehicle.CAR;

            if (type == TypeVehicle.CAR)
            {
                Vehicle vehicle = new Vehicle("Azul", "2022", 2.0, 5,4);
                vehicle.car();
            }
            else
            {
                Vehicle vehicle = new Vehicle("Violeta", "2000", 250,1, 4);
                vehicle.motocycle();

            }

            Console.ReadLine();
        }
    }
}