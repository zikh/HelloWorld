using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class TwitterMessageReader : IMessageReader
    {
        public string ReadMessage()
        {
            // connect to twitter
            return "Hello world from twiter";
        }
    }
}
