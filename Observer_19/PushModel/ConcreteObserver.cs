namespace Observer_19.PushModel
{
    public class ConcreteObserver : Observer
    {
        string observerState;

        public ConcreteObserver()
        {
        }

        public override void Update(string state)
        {
            observerState = state;
        }
    }
}