using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilty
{
    public class Hardware : IHandler
    {

        public void Handle()
        {
            Console.WriteLine("Hardware");
        }
    }
}
