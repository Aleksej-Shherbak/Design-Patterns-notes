using System;

namespace Decorator_9
{
    public class ConcreteDecoratorB: Decorator
    {
        void AdditionalBehavior()
        {
            Console.WriteLine("Винт закрутился, Карлсон летит!!!");
        }

        public override void Operation()
        {
            base.Operation();
            AdditionalBehavior();
        }
    }
}