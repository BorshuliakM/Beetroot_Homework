using System.Collections.Generic;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Reflection;

namespace Lesson_21;

internal class Program
{

    private static void Main(string[] args)
    {
        //Create application that will load assembly
        //and show all it’s classes and their methods with arguments needed to pass
        //and return types

        Assembly asm = Assembly.LoadFrom("Lesson_21.dll");
        Console.WriteLine(asm.FullName);
        Type[] types = asm.GetTypes();
        foreach (Type k in types)
        {
            Console.WriteLine(k.Name);
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