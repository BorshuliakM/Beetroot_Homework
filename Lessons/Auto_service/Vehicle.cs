using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_service
{
    public class Vehicle
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public string Vin { get; set; }
        public Vehicle(string model, int year, string vin)
        {
            Model = model;
            Year = year;
            Vin = vin;
        }
        public virtual void Start()
        {
            Console.WriteLine("Starting the vehicle");
        }

        public virtual void Stop()
        {
            Console.WriteLine("Stopping the vehicle");
        }
        public virtual void PrintInfo() => Console.WriteLine("Model {0} Year {1} Vin {2}", Model, Year, Vin);

    }
}
