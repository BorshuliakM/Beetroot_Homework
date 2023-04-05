using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_service
{
    public class Transmission
    {
        public string type { get; set; }
        public int gears { get; set; }
        public Transmission(string type, int gears)
        {
            this.type = type;
            this.gears = gears;
        }
    }
}
