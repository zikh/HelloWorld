using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class MessageWriter : IMessageWriter
    {
        public void WriteMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
