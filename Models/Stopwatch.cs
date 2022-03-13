using System;

namespace CSharpIntermediate.Models
{
    class Stopwatch
    {
        private bool Started;
        private TimeSpan Duration { get; set; }
        private DateTime StopTime;
        private DateTime StartTime;

        public void Start()
        {
            if (Started != true)
            {
                Started = true;

                StartTime = DateTime.Now;
            }
            else
            {
                throw new InvalidOperationException("The stopwatch cannot be started, until it has been stopped.");
            }
        }

        public void Stop()
        {
            if (Started == true)
            {
                Started = false;

                StopTime = DateTime.Now;

                Duration = StopTime - StartTime;
            }
            else
            {
                throw new InvalidOperationException("The stopwatch cannot be stopped, until it has been started.");
            }
        }

        public TimeSpan GetDuration()
        {
            return Duration;
        }
    }
}