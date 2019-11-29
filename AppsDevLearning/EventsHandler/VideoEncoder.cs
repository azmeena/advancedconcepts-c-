using System;
using System.Threading;
using Common;

namespace EventsHandler
{
    public class VideoEncoder
    {
        //No data
        public EventHandler VideoEncoding;

        //With data
        public EventHandler<VideoEventArgs> VideoEncoded;

        public void Encode(Video video)
        {
            OnVideoEncoding();
            Console.WriteLine($"Encode Method file '{video?.Title}'...");
            Thread.Sleep(1000);

            OnVideoEncoded(video);
            Console.WriteLine("Done");
        }

        protected virtual void OnVideoEncoding() =>
            VideoEncoding?.Invoke(this, EventArgs.Empty);

        protected virtual void OnVideoEncoded(Video video) =>
            VideoEncoded?.Invoke(this, new VideoEventArgs { Video = video });

    }
}
