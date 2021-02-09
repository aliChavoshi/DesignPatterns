using System;
using System.Threading.Channels;

namespace DesignPatterns.State.Abuse
{
    public class StopWatch
    {
        private IState _state;

        public StopWatch()
        {
            _state = new StopState(this);
        }
        public void SetState(IState state)
        {
            _state = state;
        }
        public void Click()
        {
            _state.Click();
        }
    }
}