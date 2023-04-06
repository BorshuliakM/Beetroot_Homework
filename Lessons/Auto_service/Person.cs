using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_service
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Person(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public virtual void Print() => Console.WriteLine($"Name {Name}\n Id {Id}");

    }
}
