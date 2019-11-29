
using System;
using System.Threading;
using Common;

namespace Delegates
{
    public delegate void FilterHandler(Photo photo);

    class Program
    {

        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();

            FilterHandler filterHandler = filters.ApplyBrightness;
            //Action<Photo> filterHandler = filters.ApplyBrightness;

            //multi-caste delegates
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedEyeFilter;

            processor.Process("photo.jpg", filterHandler);
            Console.ReadLine();
        }

        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Apply RemoveRedEye");
            Thread.Sleep(1000);
        }
    }
}
