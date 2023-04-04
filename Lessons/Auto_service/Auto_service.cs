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
        public string description { get; set; }
        public List<Client> clients { get; set; }
        public List<Employee> employers { get; set; }
        public Auto_service(string name, string description, Client clients, Employee employers)
        {
            this.name = name;
            this.description = description;
            this.clients = new List<Client>();
            this.employers = new List<Employee>();
        }
        public void addClient(Client client)
        {
            this.clients.Add(client);
        }
        public void removeClient(Client client)
        {
            this.clients.Remove(client);
        }
    }
}
