using System;

namespace Mediator_17.TomatoExample
{
    public class Manufactore : Colleague
    {
        public Manufactore(Mediator mediator) : base(mediator)
        {
        }

        public void MakeKetchup(string message)
        {
            // зовод делает кетчуп
            string ketchup = message + "Ketchup";
            Console.WriteLine(this.GetType().Name
                              + " produced " + ketchup);
            
            // Как только сделал - звонит посреднику.
            _mediator.Send(ketchup, this);
        }
    }
}