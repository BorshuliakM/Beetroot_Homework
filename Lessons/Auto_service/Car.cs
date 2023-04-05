using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_service
{
    public class Car : Vehicle
    {
        private string carbody;
        private Engine engine;
        private Transmission transmission;
        public Car(string model, int year, string vin, string carbody, Engine engine, Transmission transmission)
            : base(model, year, vin)
        {
            this.carbody = carbody;
            this.engine = engine;
            this.transmission = transmission;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Car model:{model}\nCar body:{carbody}\nYear:{year}\nVin:{vin}\n" +
                $"Engine:{engine.v},{engine.engine_type}\n" +
                $"Transmission:{transmission.type},{transmission.gears}");
        }

    }
}
