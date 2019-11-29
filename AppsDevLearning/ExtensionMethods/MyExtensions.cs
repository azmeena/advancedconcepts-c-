using System;
using System.Threading;
using Common;

namespace ExtensionMethods
{
    public static class MyExtensions
    {
        public static int WordCount(this string str)
        {
            return str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static void Walk(this Person person)
        {
            var step = 0;
            while (person.Capacity > step)
            {
                Console.WriteLine($"{person.FirstName} walk {++step} step");
                Thread.Sleep(400);
            }
        }
    }
}
