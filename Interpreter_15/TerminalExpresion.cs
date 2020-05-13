namespace Interpreter_15
{
    public class TerminalExpresion: AbstractExpression
    {
        public override void Interpret(Context context)
        {
            context.Result = context.Source[context.Position] == context.Vocabulary;
        }
    }
}