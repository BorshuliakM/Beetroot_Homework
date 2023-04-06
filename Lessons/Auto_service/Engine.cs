namespace Auto_service
{
    public class Engine
    {
        public string EngineType { get; set; }
        public double V { get; set; }
        public Engine(string engine_type, double v)
        {
            EngineType = engine_type;
            V = v;
        }
    }
}
