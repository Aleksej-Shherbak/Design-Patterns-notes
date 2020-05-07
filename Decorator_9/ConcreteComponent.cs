using System;

namespace Decorator_9
{
    public class ConcreteComponent: Component
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteComponent");
        }
    }
}