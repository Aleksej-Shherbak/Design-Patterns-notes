using System;

namespace Decorator_9
{
    public class ConcreteDecoratorA: Decorator
    {
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("Рубашка Карлсона");
        }
    }
}