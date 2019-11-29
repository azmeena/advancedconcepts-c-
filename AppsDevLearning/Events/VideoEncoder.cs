using Common;
using System;
using System.Threading;

namespace Events
{
    public class VideoEncoder
    {
        #region Event_Without_data

        //1-define a delegate
        public delegate void VideoEncodedHandler(object source, EventArgs args);

        //2-define an event based on that delegate
        public event VideoEncodedHandler VideoEncoded;

        protected virtual void OnVideoEncoded()
        {
            VideoEncoded?.Invoke(this, EventArgs.Empty);
        }

        #endregion

        #region Event_With_Data
        //1-define a delegate
        public delegate void VideoEncodedHandler_(object source, VideoEventArgs args);

        //2-define an event based on that delegate
        public event VideoEncodedHandler_ VideoEncoded_;

        protected virtual void OnVideoEncoded(Video video)
        {
            VideoEncoded_?.Invoke(this, new VideoEventArgs { Video = video });
        }

        #endregion

        public void Encode(Video video)
        {
            Console.WriteLine($"Encode Method file '{video?.Title}'...");
            Thread.Sleep(2500);

            //3-raise the event

            #region Event_Without_data 
            OnVideoEncoded();
            #endregion

            #region Event_With_Data
            //OnVideoEncoded(video);
            #endregion
            Console.WriteLine("Done");

        }
    }
}
