using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_domain
{
    public class Pupil
    {
        public string name;
        public int age;
        public int grade;

        public Pupil(string name, int age, int grade) 
        { 
            this.name = name;
            this.age = age;
            this.grade = grade;
        }
    }
}
