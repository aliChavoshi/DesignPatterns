namespace DesignPatterns.Mediator
{
    //Concrete Colleague
    public class Button : UiControl
    {
        private bool _isEnabled;
        public bool IsEnabled
        {
            get => _isEnabled;
            set
            {
                _isEnabled = value;
                //Call DialogBox
                NotifyObservers();
            }
        }
    }
}