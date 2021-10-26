using System;
using NetC.Utils.Contracts;

namespace NetC.Utils
{
    public class Reader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}