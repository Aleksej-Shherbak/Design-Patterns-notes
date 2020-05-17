using System;

namespace Mediator_17.TomatoExample
{
    public class Farmer : Colleague
    {
        public Farmer(Mediator mediator)
            : base(mediator)
        {
        }

        public void GrowTomato()
        {
            string tomato = "Tomato";
            Console.WriteLine(this.GetType().Name
                              + " raised " + tomato);
            // Как выросли, звонит посреднику - сбывать.
            _mediator.Send(tomato, this);
        }
    }
}