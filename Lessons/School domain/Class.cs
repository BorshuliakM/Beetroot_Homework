using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_domain
{
    public class Class
    {
        private string ClassName { get; set; }
        private Teacher Teacher { get; set; }
        private List<Pupil> Pupils { get; set; }

        public Class(string className, Teacher teacher, List<Pupil> pupils)
        {
            ClassName = className;
            Teacher = teacher;
            Pupils = pupils;
        }
        public void ChangeTeacher(Teacher teacher) 
        {
            this.Teacher = teacher;
        }
        public void AddPupil(Pupil pupil) 
        {
            Pupils.Add(pupil);
        }
        public Teacher GetTeacher() 
        { 
            return Teacher;
        }
        public List<Pupil> GetPupils() 
        {
            return Pupils;
        }
    }
}
