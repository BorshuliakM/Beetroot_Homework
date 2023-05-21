using System.Reflection;

namespace Lesson_21;

internal class Program
{
    private static void Main(string[] args)
    {
        //Create application that will load assembly
        //and show all it’s classes and their methods with arguments needed to pass
        //and return types

        Assembly asm = Assembly.LoadFrom("Test.dll");
        Console.WriteLine(asm.FullName+"\n");

        Type[] types = asm.GetTypes();

        foreach (Type type in types)
        {
            Console.WriteLine("\nClass: " + type.Name);
            MethodInfo[] methods = type.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine("\tMethod: " + method.Name);
                ParameterInfo[] parameters = method.GetParameters();
                foreach (ParameterInfo parameter in parameters)
                {
                    Console.WriteLine("\tParameter: " + parameter.Name + " Type: " + parameter.ParameterType + "");
                }
                Console.WriteLine("\tReturn Type: " + method.ReturnType);
            }
        }
        /*TestClass t = new();
        Type myType = typeof(TestClass);
        /*foreach (MemberInfo member in myType.GetMembers())
        {
            Console.WriteLine($"{member.DeclaringType} {member.MemberType} {member.Name}");
        }
        t.Print();
        var testProp = myType.GetProperty("TestProperty2");
        var prop = testProp?.GetValue(t);
        testProp?.SetValue(t, 22);
        t.Print();*/
    }
}