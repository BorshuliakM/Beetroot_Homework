using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_service
{
    internal class Auto_service
    {
        public string name { get; set; }
        public string desc { get; set; }
        public List<Client> clients { get; set; }
        public List<Employee> employers { get; set; }
        public Auto_service(string name, string desc, Client clients, Employee employers)
        {
            this.name = name;
            this.desc = desc;
            this.clients = new List<Client>();
            this.employers = new List<Employee>();
        }
        public void PrintInfo() => Console.WriteLine(name, desc);
        public void PrintEmployers()
        {
            foreach (var e in employers) 
            {
                Console.WriteLine(e.name);
            }
        }
        public void PrintClients()
        {
            foreach (var e in clients)
            {
                Console.WriteLine(e.name);
            }
        }
    }
}
