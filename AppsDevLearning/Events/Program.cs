
using System;
using Common;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            var videoEncoder = new VideoEncoder();

            //subscribing to the event
            videoEncoder.VideoEncoded += MailService.OnVideoEncoded;

            videoEncoder.VideoEncoded_ += MailService.OnVideoEncoded_;

            videoEncoder.Encode(new Video());

            Console.ReadLine();
        }
    }
}
