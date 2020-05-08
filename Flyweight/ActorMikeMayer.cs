using System;

namespace Flyweight
{
    public class ActorMikeMayer: Flyweight
    {
        public override void Greeting(string speech)
        {
            Console.WriteLine(speech);
        }
    }
}