using System;
using System.Threading;

namespace Common
{
    public class MailService
    {
        public static void OnVideoEncoded(object source, EventArgs args)
        {
            Console.WriteLine("Sending the file in mail (event no data)");
            Thread.Sleep(1000);
        }

        public static void OnVideoEncoded_(object source, VideoEventArgs args)
        {
            Console.WriteLine($"Sending '{args?.Video?.Title}' in mail (event with data)");
            Thread.Sleep(1000);
        }
    }
}