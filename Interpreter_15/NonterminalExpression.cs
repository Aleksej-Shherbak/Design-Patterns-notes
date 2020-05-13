namespace Interpreter_15
{
    public class NonterminalExpression : AbstractExpression
    {
        private AbstractExpression nonterminalExpression;
        private AbstractExpression terminalExpresion;

        public override void Interpret(Context context)
        {
            if (context.Position < context.Source.Length)
            {
                terminalExpresion = new TerminalExpresion();
                terminalExpresion.Interpret(context);
                context.Position++;

                if (context.Result)
                {
                    nonterminalExpression = new NonterminalExpression();
                    // идем рекурсивно
                    nonterminalExpression.Interpret(context);
                }
            }
        }
    }
}