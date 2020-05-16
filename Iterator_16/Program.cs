using System;
using System.Collections;
using System.ComponentModel;
using Iterator_16.BankExample;
using Iterator_16.GoFWay;
using Component = Iterator_16.ContainerExample.Component;
using Container = Iterator_16.ContainerExample.Container;

namespace Iterator_16
{
    class Program
    {
        static void StartBankExample()
        {
            IEnumerable bank = new Bank();
            IEnumerator cashier = bank.GetEnumerator();

            while (cashier.MoveNext())
            {
                Banknote banknote = cashier.Current as Banknote;
                Console.WriteLine(banknote.Nominale);
            }
            // cashier.Reset();
        }


        static void ContainerExample()
        {
            Container container = new Container();
            Component component1 = new Component();
            Component component2 = new Component();
            Component component3 = new Component();
  
            container.Add(component1, "first");
            container.Add(component2, "second");
            container.Add(component3, "therd");

            ComponentCollection components = container.Components;

            foreach (IComponent component in components)
            {
                Console.WriteLine($"Component : {component.Site.Name}");       
            }

            component1.Disposed += (object sender, EventArgs eventArgs) =>
                Console.WriteLine("First component disposed");
            
            container.Dispose();
        }

        static void GofIteratorExample()
        {
            Aggregate a = new ConcreteAggregate();

            a[0] = "Element A";
            a[1] = "Element B";
            a[2] = "Element C";

            Iterator i = a.CreateIterator();

            for (object o = i.First(); !i.IsDone(); o = i.Next())
            {
                Console.WriteLine(o);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Bank example");
            StartBankExample();
            Console.WriteLine(new string('=', 20));
            Console.WriteLine();

            Console.WriteLine("Container example");
            ContainerExample();
            Console.WriteLine(new string('=', 20));
            Console.WriteLine();
            
            Console.WriteLine("Gof Iterator implementation");
            GofIteratorExample();
            Console.WriteLine(new string('=', 20));
            Console.WriteLine();
        }
    }
}