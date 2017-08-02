using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class HelloWorld
    {
        private IMessageReader _messageReader;
        private IMessageWriter _messageWriter;
        public HelloWorld(IMessageReader messageReader, IMessageWriter messageWriter)
        {
            _messageReader = messageReader;
            _messageWriter = messageWriter;
        }
        internal void Message()
        {
            _messageWriter.WriteMessage(_messageReader.ReadMessage());
        }
    }
}
