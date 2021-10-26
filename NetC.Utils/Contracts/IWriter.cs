using System;
using System.Collections.Generic;
using System.Text;

namespace NetC.Utils.Contracts
{
    public interface IWriter
    {
        /// <summary>
        /// Writes a string to a stream.
        /// </summary>
        /// <param name="str">The string to be written</param>
        public void Write(string str);
        /// <summary>
        /// Writes a line separator to a stream.
        /// </summary>
        public void WriteLine();
        /// <summary>
        /// Writes a string and a line separator to a stream.
        /// </summary>
        /// <param name="str">The string to be written</param>
        public void WriteLine(string str);
    }
}
