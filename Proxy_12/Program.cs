using System;

namespace Proxy_12
{
    class Program
    {
        static void Main(string[] args)
        {
            IHuman bruce = new Operator();
            IHuman surrogate = new Surrogate(bruce);
            
            surrogate.Request();
        }
    }
}