using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_service
{
    public class Vehicle
    {
        public string model { get; set; }
        public int year { get; set; }
        public string vin { get; set; }
        public Vehicle(string model, int year, string vin)
        {
            this.model = model;
            this.year = year;
            this.vin = vin;
        }
        public virtual void Start()
        {
            Console.WriteLine("Starting the vehicle");
        }

        public virtual void Stop()
        {
            Console.WriteLine("Stopping the vehicle");
        }
        public virtual void PrintInfo() => Console.WriteLine("Model {0} Year {1} Vin {2}", model, year, vin);

    }
}
