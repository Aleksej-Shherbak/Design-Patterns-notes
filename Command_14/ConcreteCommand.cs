namespace Command_14
{
    public class ConcreteCommand: Command
    {
        /// <summary>
        /// Конфигурируем заказ нужным повором. Могут спросить, какой именно повар будет готовить вам заказ?
        /// Итальянский, французский? Определенные заказы идут определенным поворам.
        /// </summary>
        /// <param name="receiver"></param>
        public ConcreteCommand(Receiver receiver) : base(receiver)
        {
        }

        public override void Execute()
        {
            receiver.Action();
        }
    }
}