using School_domain;

internal class Program
{
    private static void Main(string[] args)
    {
        School School_9 = new School("Some school");
        Teacher teacherr = new Teacher("Bob", 34, "Chemistry");
        Teacher tchr = new Teacher("Andrew", 27, "Math");
        Pupil pupill = new Pupil("David", 10, 5);
        Class clas = new Class("5 grade", teacherr, new List<Pupil> { pupill });
        clas.ChangeTeacher(tchr);
        Teacher tc = clas.GetTeacher();
        tc.PrintInfo();
    }
}