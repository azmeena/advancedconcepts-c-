using System;
using System.Threading;
using Common;

namespace Delegates
{
    public class PhotoFilters
    {
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Apply brightness");
            Thread.Sleep(1000);

        }

        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Apply contrast");
            Thread.Sleep(1000);

        }

        public void Resize(Photo photo)
        {
            Console.WriteLine("Resize photo");
            Thread.Sleep(1000);

        }
    }
}