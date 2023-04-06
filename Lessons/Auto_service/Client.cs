namespace Auto_service
{
    internal class Client : Person
    {
        public Car Vehicle { get; set; }
        public Client(int id, string name, Car vehicle) : base(id, name)
        {
            Vehicle = vehicle;
        }
        public override void Print() => Console.WriteLine("Name:{0} id:{1} Vehicle:{2}", Name, Id, Vehicle.Model);
    }
}