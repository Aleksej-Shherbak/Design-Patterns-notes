namespace Command_14
{
    /// <summary>
    /// Официант
    /// </summary>
    public class Invoker
    {
        private Command _command;

        public void StoreCommand(Command command)
        {
            _command = command;
        }

        public void ExecuteCommand()
        {
            _command.Execute();
        }
    }
}