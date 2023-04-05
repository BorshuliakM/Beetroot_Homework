namespace Auto_service
{
    internal class Client : Person
    {
        public Car vehicle;
        public Client(int id, string name, Car vehicle) : base(id, name)
        {
            this.vehicle = vehicle;
        }
        public override void Print() => Console.WriteLine("Name:{0} id:{1} Vehicle:{2}",name,id,vehicle.model);
    }
}