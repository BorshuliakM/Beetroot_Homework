namespace Auto_service
{
    internal class Client : Person
    {
        private Vehicle vehicle;
        public Client(int id, string name, Vehicle vehicle) : base(id, name)
        {
            this.vehicle = vehicle;
        }

    }
}