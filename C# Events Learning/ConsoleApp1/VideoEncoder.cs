using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class VideoEncoder
    {
        //1. -Define a delegate. This class (VideoEncoder) is the publisher of the event
        //2. - Define an Event based on delegate
        //3. - Raise the Event

        public delegate void VideoEncodedEventHandler(object source, EventArgs args); // Created a delegate

        public event VideoEncodedEventHandler VideoEncoded; //Defined an event based on delegate
         


        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video,,,");
            Thread.Sleep(3000);

            OnVideoEncoded();

        }

        protected virtual void OnVideoEncoded() //Created a method for raising the event 
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, EventArgs.Empty);
            }

        }
    }
}
