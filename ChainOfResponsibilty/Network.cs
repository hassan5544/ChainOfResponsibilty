using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilty
{
    public class Network : IHandler
    {
        private readonly IHandler _nextHandler;

        Software software = new Software();
        public Network()
        {
            _nextHandler = software;
        }
        public void Handle()
        {
            Console.WriteLine("Network");
            _nextHandler.Handle();
        }
    }
}
