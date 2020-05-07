using System;

namespace Decorator_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Component carlson = new ConcreteComponent();
            
            Decorator decoratorA = new ConcreteDecoratorA();
            Decorator decoratorB = new ConcreteDecoratorB();

            // одеваем на Карлсона рубашку
            decoratorA.Component = carlson;
            
            // а теперь на Карлсона с рубашкой сверху вешаем пропеллер
            decoratorB.Component = decoratorA;
            
            decoratorB.Operation();
        }
    }
}