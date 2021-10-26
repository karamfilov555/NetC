using System;
using NetC.Utils.Contracts;

namespace NetC.Utils
{
    public class Writer : IWriter
    {
        public void Write(string str) 
        {
            Console.Write(str);
        }
        public void WriteLine()
        {
            Console.WriteLine();
        }
        public void WriteLine(string str)
        {
            Console.WriteLine(str);
        }
    }
}
