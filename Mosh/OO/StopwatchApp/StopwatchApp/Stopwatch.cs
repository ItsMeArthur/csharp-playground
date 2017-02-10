using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopwatchApp
{
    class Stopwatch
    {
        private DateTime? StartTime { get; set; }
        private DateTime? StopTime { get; set; }
        public bool IsRunning { get; set; }

        public Stopwatch()
        {

        }

        public Stopwatch(bool start)
            : this()
        {
            if (start)
            {
                Start();
            }
        }

        public TimeSpan? Duration
        {
            get
            {
                if (StartTime == null)
                    throw new InvalidOperationException("Start time is null. Cannot calculate duration.");
                
                if (IsRunning)
                    return DateTime.Now - StartTime;
                else
                    return StopTime - StartTime;
            }
        }

        public void Start()
        {
            StartTime = DateTime.Now;
            IsRunning = true;
        }

        public void Stop()
        {
            StopTime = DateTime.Now;
            IsRunning = false;
        }
    }
}
