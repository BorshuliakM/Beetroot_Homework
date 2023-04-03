using System.Security.Claims;

namespace School_domain
{
    public class School
    {
        private string school_name;
        private List<Pupil> pupils;
        private List<Teacher> teachers;
        private List<Class> classes;

        public School(string school_name)
        {
            this.school_name = school_name;
            pupils = new List<Pupil>();
            teachers = new List<Teacher>();
            classes = new List<Class>();
        }
        public void ChangeName(string name)
        {
            name = school_name;
        }

        public void AddPupil(Pupil pupil)
        {
            pupils.Add(pupil);
        }

        public void AddTeacher(Teacher teacher)
        {
            teachers.Add(teacher);
        }

        public void AddClass(Class Class)
        {
            classes.Add(Class);
        }

        public List<Pupil> GetPupils()
        {
            return pupils;
        }

        public List<Teacher> GetTeachers()
        {
            return teachers;
        }

        public List<Class> GetClasses()
        {
            return classes;
        }
    }
}