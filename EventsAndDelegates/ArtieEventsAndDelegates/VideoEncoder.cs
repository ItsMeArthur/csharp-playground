using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    class VideoEncoder
    {
        public event VideoBeforeEncodingDelegate BeforeEncoding;
        public event VideoEncodedDelegate AfterEncoding;

        public void Encode(Video video)
        {
            BeforeEncoding(this, new VideoEncodingEventArgs());
            Thread.Sleep(3000);
            AfterEncoding(this, new VideoEncodedEventArgs());
        }
    }
}
