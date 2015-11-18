using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DaLibrary
{
    public class DaClass
    {
        public int I;

        public delegate void OutputFuncType(string str);

        public OutputFuncType OutputFunc;

        public void DoSometing()
        {
            if (OutputFunc != null)
                OutputFunc("Me contains " + I);
        }
    }
}
