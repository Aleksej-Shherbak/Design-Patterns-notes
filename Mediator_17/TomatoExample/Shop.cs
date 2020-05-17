using System;

namespace Mediator_17.TomatoExample
{
    public class Shop: Colleague
    {
        public Shop(Mediator mediator) : base(mediator)
        {
        }
        
        public void SellKetchup(string message)
        {
            // размещение кетчупа в магазиние
            Console.WriteLine(this.GetType().Name
                              + " sold " + message);
        }
    }
}