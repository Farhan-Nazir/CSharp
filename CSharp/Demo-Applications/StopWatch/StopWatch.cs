using System;
namespace CSharp.DemoApplications.StopWatch
{
    public class StopWatch
    {
        private DateTime _startTime;
        private DateTime _endTime;
        private bool _isStarted;

        public void StartTimer()
        {
            if(_isStarted)
            {
                throw new InvalidOperationException("Timer is alread started !!!!");
            }

            _startTime = DateTime.Now;
            _isStarted = true;

        }

        public void EndTimer()
        {
            if (!_isStarted)
            {
                throw new InvalidOperationException("Timer is not started !!!!");
            }

            _endTime = DateTime.Now;
            _isStarted = false;
        }

        public TimeSpan GetInterval()
        {
            return _endTime - _startTime;
        }
    }
}
