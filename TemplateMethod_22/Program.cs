using System;

namespace TemplateMethod_22
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractClass instance = new ConcreteClass();
            instance.TemplateMethod();
        }
    }
}