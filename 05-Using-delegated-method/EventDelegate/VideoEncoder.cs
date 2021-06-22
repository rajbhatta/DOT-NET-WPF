using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EventDelegate
{

    public class VideoEncoder
    {
        // 1-Define a delegate
        // 2-Define an event based on that delegate
        // 3-Raise the event


        // 1-Define a delegate
        public delegate void VideoEncodedEventHandler(object source, EventArgs args);

        //2-Define an event based on that delegate
        public event VideoEncodedEventHandler VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);
        }

        // 3-raise the event; dot net convention- method must be onFunctionName, void, virtual
        protected virtual void onVideoEncoded()
        {
            //notify all the subscribers
            // check if any subscriber to the event
            if (VideoEncoded != null)
                //event defined in step 2 but containing signature of delegate of step 1
                VideoEncoded(this, EventArgs.Empty);
        }



    }
}
