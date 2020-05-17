namespace Mediator_17.TomatoExample
{
    public abstract class Mediator
    {
        public abstract void Send(string message, Colleague colleague);
    }
}