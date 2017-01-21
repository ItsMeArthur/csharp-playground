using System;
using System.Threading;

namespace EventsAndDelegates
{
    class VideoEncoder
    {
        //Creates the delegate with the desired signature
        public delegate void VideoEncodedEventHandler(object sender, VideoEncoderEventArgs args);
        //Creates the event of the type of the declared delegate
        public event VideoEncodedEventHandler VideoEncoded;

        public void Encode(Video video)
        {
            //Do the encoding stuff
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);
            //Raise the event telling the encoding is done
            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            //Check if the event has subscribers
            if (VideoEncoded != null)
            {
                //Raise the event passing this object and empty parameters
                VideoEncoded(this, new VideoEncoderEventArgs() { Video = video });                
            }
        }
    }
}
