using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    class Vehicle
    {
        private string color;
        private string year;
        private double engine;
        private int seats;
        private int doors;

        public Vehicle (string color, string year, double engine, int seats, int doors)
        {
            this.color = color;
            this.year = year;
            this.engine = engine;
            this.seats = seats;
            this.doors = doors;
        }

        public void car()
        {
            Console.WriteLine($"Criando um carro {color},{year},{doors} portas {engine} e {seats}");
            startVehicle();
        }

        public void startVehicle()
        {
            Console.WriteLine("Motor ligado");
        }

        public void motocycle()
        {
            Console.WriteLine($"Criando uma moto {color},{year}, {engine} cilindradas");
            startVehicle();
        }
    }
}