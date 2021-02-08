using System;

namespace DesignPatterns.State.Abuse
{
    public class RunningState : IState
    {
        private readonly StopWatch _stopWatch;
        public RunningState(StopWatch stopWatch)
        {
            _stopWatch = stopWatch;
        }
        public void Click()
        {
            _stopWatch.SetState(new StopState(_stopWatch));
            Console.WriteLine("Stopped");
        }
    }
}