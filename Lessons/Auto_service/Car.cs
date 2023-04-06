using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_service
{
    public class Car : Vehicle
    {
        private string _carbody;
        private Engine _engine;
        private Transmission _transmission;
        public Car(string model, int year, string vin, string carbody, Engine engine, Transmission transmission)
            : base(model, year, vin)
        {
            _carbody = carbody;
            _engine = engine;
            _transmission = transmission;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Car model:{Model}\nCar body:{_carbody}\nYear:{Year}\nVin:{Vin}\n" +
                $"Engine:{_engine.V},{_engine.EngineType}\n" +
                $"Transmission:{_transmission.Type},{_transmission.Gears}");
        }

    }
}
