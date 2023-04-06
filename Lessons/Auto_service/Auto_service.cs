using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_service
{
    internal class Auto_service
    {
        public string Name { get; set; }
        public string Desc { get; set; }
        public List<Client> Clients { get; set; }
        public List<Employee> Employers { get; set; }
        public Auto_service(string name, string desc, Client clients, Employee employers)
        {
            Name = name;
            Desc = desc;
            Clients = new List<Client>();
            Employers = new List<Employee>();
        }
        public void PrintInfo() => Console.WriteLine(Name, Desc);
        public void PrintEmployers()
        {
            foreach (var e in Employers) 
            {
                Console.WriteLine(e.Name);
            }
        }
        public void PrintClients()
        {
            foreach (var e in Clients)
            {
                Console.WriteLine(e.Name);
            }
        }
    }
}
