using System;

namespace ChainOfResponsibility_13
{
    public class ConcreteHandler1 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request == 1)
            {
                Console.WriteLine("One");
            }
            else if (Successor != null)
            {
                Successor.HandleRequest(request);
            }
        }
    }
}