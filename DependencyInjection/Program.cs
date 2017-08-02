using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            var messageReader = new TwitterMessageReader();
            var messageWriter = new FacebookMessageWriter();
            var helloWorld = new HelloWorld(messageReader, messageWriter);
            helloWorld.Message();
        }
    }
}
