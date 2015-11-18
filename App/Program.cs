using System;
using System.Reflection;
using DaLibrary;
using static System.Console;

namespace App
{
    class ReflectMe
    {
        public int I;
        public string Str;
    };

    class Program
    {
        static void ReflectIt(Type o)
        {
            WriteLine(o.Name + " contains:");
            foreach (MemberInfo m in o.GetMembers())
            {
                WriteLine(m.Name);
            }
        }

        static void Main(string[] args)
        {
            WriteLine("Hello JSIL");

            ReflectIt(new ReflectMe().GetType());

            DaClass daClass = new DaClass { I = 42, OutputFunc = (s) => { Console.WriteLine(s);}};
            daClass.DoSometing();
        }
    }
}
