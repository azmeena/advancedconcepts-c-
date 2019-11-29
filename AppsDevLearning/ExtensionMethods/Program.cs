using System;
using Common;

namespace ExtensionMethods
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const string para = "This is the c# learning presentation. Azmeena is the presenter.";
            var result = para.WordCount();

            Console.WriteLine(result);

            var meggi = new Person { FirstName = "Mariana", Capacity = 10 };
            meggi.Walk();

            var jesica = new Person { FirstName = "Jessica" };

            MyExtensions.Walk(jesica); //another way

            Console.Read();
        }
    }
}
