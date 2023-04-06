using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_service
{
    internal class Employee : Person
    {
        public Auto_service AutoService { get; set; }
        public Employee(int id, string name, Auto_service autoService) : base(id, name)
        {
            AutoService = autoService;
        }
        public override void Print() => Console.WriteLine("Name:{0} id:{1} Autoservice:{2}", Name, Id, AutoService.Name);
    }
}
