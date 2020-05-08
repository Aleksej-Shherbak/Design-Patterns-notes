using System;

namespace Flyweight_11
{
    public class ActorMikeMayer: Flyweight
    {
        public override void Greeting(string speech)
        {
            Console.WriteLine(speech);
        }
    }
}