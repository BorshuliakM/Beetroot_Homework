namespace Auto_service
{
    public class Engine
    {
        public string engine_type { get; set; }
        public double v { get; set; }
        public Engine(string engine_type, double v)
        {
            this.engine_type = engine_type;
            this.v = v;
        }
    }
}
