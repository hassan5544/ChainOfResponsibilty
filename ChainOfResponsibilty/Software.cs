using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilty
{
    public class Software : IHandler
    {
        private readonly IHandler _nextHandler;

        Hardware hardware = new Hardware();
        public Software()
        {
            _nextHandler = hardware;
        }
        public void Handle()
        {
            Console.WriteLine("sofrware");
            _nextHandler.Handle();
        }
    }
}
