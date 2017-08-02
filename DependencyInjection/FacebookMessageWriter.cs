using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class FacebookMessageWriter : IMessageWriter
    {
        public void WriteMessage(string message)
        {
            // complex logic to conect with facebook
            Console.WriteLine("Facebook: {0}", message);
        }
    }
}
