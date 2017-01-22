using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
namespace CustomTimer
{
    class Program
    {
        public static Library.CustomTimer timer { get; set; }
        static void Main(string[] args)
        {
            timer = new Library.CustomTimer();
            timer.Interval = 100;
            timer.TimeRefresh += WriteStuff;
            timer.Start();
        }

        static void WriteStuff(object sender, EventArgs e)
        {
            Console.WriteLine($"PRINT THIS {timer.Time}");
        }
    }
}
