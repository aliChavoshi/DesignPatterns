using System;

namespace DesignPatterns.State.Abuse
{
    public class StopState : IState
    {
        private readonly StopWatch _stopWatch;
        public StopState(StopWatch stopWatch)
        {
            _stopWatch = stopWatch;
        }
        public void Click()
        {
            _stopWatch.SetState(new RunningState(_stopWatch));
            Console.WriteLine("Running");
        }
    }
}