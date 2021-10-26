using System;
using System.Collections.Generic;
using System.Text;

namespace NetC.Utils.Contracts
{
    public interface IReader
    {
        /// <summary>
        /// Reads a line from a stream.
        /// </summary>
        /// <returns>The read line from the stream.</returns>
        public string ReadLine();
    }
}
