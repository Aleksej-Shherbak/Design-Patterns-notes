using System;

namespace Visitor_23.SantaExample
{
    public class GirlsHouse : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitGirlsHouse(this);
        }

        /// <summary>
        /// Девочка заказала новое платье.
        /// </summary>
        public void GiveNewDress()
        {
            Console.WriteLine("Dress as a gift!!!");
        }
    }
}