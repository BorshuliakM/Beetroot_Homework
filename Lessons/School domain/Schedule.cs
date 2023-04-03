using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_domain
{
    public class Schedule
    {
        private List<Class> classes;

        public Schedule(List<Class> classes)
        {
            this.classes = classes;
        }

        public List<Class> GetClasses()
        {
            return classes;
        }
    }
}
