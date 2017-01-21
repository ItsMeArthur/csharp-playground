using System;

namespace EventsAndDelegates
{
    class MailService
    {
        public void OnVideoEncoded(object sender, VideoEncoderEventArgs args)
        {
            Console.WriteLine("MailService: Sending an email..." + args.Video.Title);
        }
    }
}
