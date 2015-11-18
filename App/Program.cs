using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
        static IEnumerable<string> ReflectIt(Type o)
        {
            WriteLine(o.Name + " contains:");
            foreach (MemberInfo m in o.GetMembers())
            {
                yield return m.Name;
            }
        }

        static void Main(string[] args)
        {
            WriteLine("Hello JSIL");

            List<string> members = new List<string>(ReflectIt(new ReflectMe().GetType()).ToArray());

            foreach (var member in members)
            {
                WriteLine(member);
            }

            DaClass daClass = new DaClass { I = 42, OutputFunc = (s) => { Console.WriteLine(s);}};
            daClass.DoSometing();
        }
    }
}
