using System;

namespace Strategy_21
{
    class Program
    {
        static void Main()
        {
            var sort = new SelectionSort();
            var context = new Context(sort);
            context.Sort();
            context.PrintArray();
        }
    }
}