namespace School_domain
{
    public class School
    {
        private string school_name;
        private string school_type;


        public School(string school_name, string school_type) 
        { 
            this.school_name = school_name;
            this.school_type = school_type;
        }
        public void ChangeName(string name, string type)
        {
            name=school_name;
            type=school_type;
        }

    }
}