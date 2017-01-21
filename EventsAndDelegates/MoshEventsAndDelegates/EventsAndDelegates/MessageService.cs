using System;

namespace EventsAndDelegates
{
    class MessageService
    {
        public void OnVideoEncoded(object sender, VideoEncoderEventArgs args)
        {
            Console.WriteLine("MessageService: Sending message..." + args.Video.Title);
        }
    }
}
