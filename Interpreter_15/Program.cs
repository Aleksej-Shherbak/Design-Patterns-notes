using System;

namespace Interpreter_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context
            {
                Vocabulary = 'a',
                Source = "aaa"
            };
            
            var expresion = new NonterminalExpression();
            expresion.Interpret(context);
            
            Console.WriteLine(context.Result);
        }
    }
}