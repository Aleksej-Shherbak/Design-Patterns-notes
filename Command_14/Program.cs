using System;

namespace Command_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Receiver receiver = new Receiver();
            // определенное блюдо умеет готовить определенный повар
            Command order = new ConcreteCommand(receiver);
            Invoker waiter = new Invoker();
            
            // делаем заказ
            waiter.StoreCommand(order);
            waiter.ExecuteCommand();
        }
    }
}