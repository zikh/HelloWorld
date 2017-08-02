using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class MessageReader : IMessageReader
    {
        public string ReadMessage()
        {
            return "Hello, World";
        }
    }
}
