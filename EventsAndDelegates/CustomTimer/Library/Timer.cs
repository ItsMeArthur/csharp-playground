using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Library
{
    public class CustomTimer
    {
        public delegate void TimerEventHandler(object sender, EventArgs e);
        public event TimerEventHandler TimeRefresh;

        private bool _execute;
        public int Interval { get; set; }
        public int Time { get; set; }

        public CustomTimer()
        {
            _execute = false;
            Interval = 1000;
            Time = 0;
        }

        public void Start()
        {
            _execute = true;
            ExecuteAsync();
        }
        public void Stop() => _execute = false;

        private async void ExecuteAsync()
        {
            while (_execute)
            {
                Time += Interval;
                if (TimeRefresh != null)
                {
                    TimeRefresh(this, EventArgs.Empty);
                    Thread.Sleep(Interval);
                }
            }
        }
    }
}
