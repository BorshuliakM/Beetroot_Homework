using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_domain
{
    public class Teacher
    {
        public string name;
        public int age;
        public string specialization;
        public Teacher(string name, int age, string specialization) 
        {
            this.name = name;
            this.age = age;
            this.specialization = specialization;
        }
        public void PrintInfo()
        {
            Console.WriteLine("Name = {0} Age = {1} Specialization = {2}",name,age,specialization);
        }
    }
}
