using System;

namespace TemplateMethod_22
{
    public class ConcreteClass: AbstractClass
    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("PrimitiveOperation1");
        }
        public override void PrimitiveOperation2()
        {
            Console.WriteLine("PrimitiveOperation2");
        }
    }
}