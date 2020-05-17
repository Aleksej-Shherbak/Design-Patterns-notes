namespace Mediator_17.TomatoExample
{
    public class ConcreteMediator : Mediator
    {
        public Farmer Farmer { get; set; }
        public Manufactore Manufactore { get; set; }
        public Shop Shop { get; set; }

        public override void Send(string message,
            Colleague colleague)
        {
            if (colleague == Farmer)
            {
                // если позвонил фермер по поводу помидоров - передаем на прозиводство
                Manufactore.MakeKetchup(message);
            }
            else if (colleague == Manufactore)
            {
                // если позвонил зовод, то посредник звонит в магазин - размещать товар.
                Shop.SellKetchup(message);
            }
        }
    }
}