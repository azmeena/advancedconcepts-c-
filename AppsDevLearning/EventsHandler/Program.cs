using System;
using System.Threading;
using Common;

namespace EventsHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            var videoEncoder = new VideoEncoder();

            //subscribing to the event
            videoEncoder.VideoEncoding += OnEncoding;
            videoEncoder.VideoEncoded += MailService.OnVideoEncoded_;

            videoEncoder.Encode(new Video());

            Console.ReadLine();
        }

        public static void OnEncoding(object source, EventArgs eventArgs)
        {
            Console.WriteLine("Started encoding (event no data)");
            Thread.Sleep(1000);
        }
    }
}
