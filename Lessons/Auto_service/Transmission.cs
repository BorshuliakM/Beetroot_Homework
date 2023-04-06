using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_service
{
    public class Transmission
    {
        public string Type { get; set; }
        public int Gears { get; set; }
        public Transmission(string type, int gears)
        {
            Type = type;
            Gears = gears;
        }
    }
}
