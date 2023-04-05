using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_service
{
    internal class Employee : Person
    {
        public Auto_service auto_Service { get; set; }
        public Employee(int id, string name, Auto_service auto_Service) : base(id, name)
        {
            this.auto_Service = auto_Service;
        }
        public override void Print() => Console.WriteLine("Name:{0} id:{1} Autoservice:{2}", name, id, auto_Service.name);
    }
}
