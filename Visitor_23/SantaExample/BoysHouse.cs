using System;

namespace Visitor_23.SantaExample
{
    public class BoysHouse: Element
    {
        public override void Accept(Visitor visitor)
        {
            // допустим, тут деду-морозу разрешили войти
            visitor.VisitBoysHouse(this);
        }

        /// <summary>
        /// В качестве подарка мальчик заказал сказку.
        /// </summary>
        public void TellFairyTale()
        {
            Console.WriteLine("Fairy Tale ... bla bla bla ...");
        }
    }
}