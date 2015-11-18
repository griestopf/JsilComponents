using System;
using DaLibrary;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello JSIL");
            DaClass daClass = new DaClass { I = 42, OutputFunc = (s) => { Console.WriteLine(s);}};
            daClass.DoSometing();
        }
    }
}
