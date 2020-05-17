using System;
using Memento_18.MetaphofImplementation;
using Memento_18.OfficialExample;

namespace Memento_18
{
    class Program
    {
        static void RobotExample()
        {
            Man man = new Man();
            Robot robot = new Robot();
            man.Сlothes = "Футболка, Джинсы, Кеды";
            robot.Backpack = man.Undress();
            man.Сlothes = "Шорты спортивные";
            man.Dress(robot.Backpack);
        }

        static void OfficialExample()
        {
            Originator originator = new Originator();
            originator.State = "On";
            Caretaker caretaker = new Caretaker();
            caretaker.Memento = originator.CreateMemento();
            originator.State = "Off";
            originator.SetMemento(caretaker.Memento);
        }

        static void Main(string[] args)
        {
            RobotExample();
            Console.WriteLine(new string('=', 20));
            
        }
    }
}