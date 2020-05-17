using System;
using Observer_19.PullModel;
using Observer_19.PushModel;

namespace Observer_19
{
    class Program
    {
        static void PullModelExample()
        {
            PullModel.ConcreteSubject subject = new PullModel.ConcreteSubject();
            subject.Attach(new PullModel.ConcreteObserver(subject));
            subject.Attach(new PullModel.ConcreteObserver(subject));
            subject.State = "Some State ...";
            subject.Notify();
        }

        static void PushExample()
        {
            PushModel.ConcreteSubject subject = new PushModel.ConcreteSubject();
            subject.Attach(new PushModel.ConcreteObserver());
            subject.Attach(new PushModel.ConcreteObserver());
            subject.State = "Some State ...";
            subject.Notify();
        }

        static void Main(string[] args)
        {
            PullModelExample();

            Console.WriteLine(new string('=', 20));
            
            PushExample();
        }
    }
}