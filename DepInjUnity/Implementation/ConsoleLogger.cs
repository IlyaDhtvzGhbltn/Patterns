using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepInjUnity.Implementation
{
    class ConsoleLogger : ILogger
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}
