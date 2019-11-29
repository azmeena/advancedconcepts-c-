using System;
using System.Threading;

namespace Common
{
    public class Photo
    {
        public static Photo Load(string path)
        {
            Console.WriteLine($"Loading {path}...");
            Thread.Sleep(1000);
            return new Photo();
        }

        public void Save()
        {
            Console.WriteLine("Saving...");
            Thread.Sleep(1000);
            Console.WriteLine("Done");
        }
    }
}