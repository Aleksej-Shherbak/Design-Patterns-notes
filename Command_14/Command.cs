namespace Command_14
{
    /// <summary>
    /// Абстрактный листок с заказом
    /// </summary>
    public abstract class Command
    {
        protected Receiver receiver;

        public Command(Receiver receiver)
        {
            this.receiver = receiver;
        }

        public abstract void Execute();
    }
}