using System;

namespace ChainOfResponsibility_13
{
    public class ConcreteHandler2: Handler
    {
        public override void HandleRequest(int request)
        {
            if (request == 2)
            {
                Console.WriteLine("Two");
            }
            else if (Successor != null)
            {
                Successor.HandleRequest(request);
            }
        }
    }
}