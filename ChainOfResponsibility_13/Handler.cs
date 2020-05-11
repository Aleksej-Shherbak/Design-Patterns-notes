namespace ChainOfResponsibility_13
{
    public abstract class Handler
    {
        public Handler Successor { get; set; }
        public abstract void HandleRequest(int request);
    }
}