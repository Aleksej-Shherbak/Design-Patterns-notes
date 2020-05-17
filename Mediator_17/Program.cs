using System;
using Mediator_17.TomatoExample;

namespace Mediator_17
{
    class Program
    {
        static void Main(string[] args)
        {
            var mediator = new ConcreteMediator();
            var farmer = new Farmer(mediator);
            var manufacture = new Manufactore(mediator);
            var shop = new Shop(mediator);
            mediator.Farmer = farmer;
            mediator.Manufactore = manufacture;
            mediator.Shop = shop;
            
            // Фермер растит помидоры
            farmer.GrowTomato();
        }
    }
}