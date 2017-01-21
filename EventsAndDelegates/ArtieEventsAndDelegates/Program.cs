using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Video video = new Video() { Title = "Video 1" };
            VideoEncoder videoEncoder = new VideoEncoder();

            videoEncoder.BeforeEncoding += (sender, e) => { Console.WriteLine("Video is about to be encoded"); };
            videoEncoder.AfterEncoding += (sender, e) => { Console.WriteLine("Video was encoded!"); };

            videoEncoder.Encode(video);

            Console.ReadLine();
        }
    }
}
