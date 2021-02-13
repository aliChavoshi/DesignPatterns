namespace DesignPatterns.CommandPattern.fx
{
    public class Button
    {
        private readonly ICommand _command;
        private string _label;
        public Button(ICommand command, string label)
        {
            _command = command;
            _label = label;
        }
        public void Click()
        {
            _command.Execute();
        }
    }
}