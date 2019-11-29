using System;
using System.Collections;
using System.Collections.Generic;
using Common;
using NGMath = Generics.Math_NonGeneric;
using GMath = Generics.Math_Generic;

namespace Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            WorkWithArrayList();
            WorkWithGenericList();
            Add();
            Console.ReadLine();
        }

        private static void WorkWithArrayList()
        {
            ArrayList myInts = new ArrayList { 10, 20, 35 };

            int i = (int)myInts[0];
            Console.WriteLine($"value of your int with non-generic collection is {i}");
        }

        private static void WorkWithGenericList()
        {
            List<int> myInts = new List<int> { 10, 20, 35 };
            Console.WriteLine($"value of your int with generic collection is {myInts[0]}");
        }

        public static void Add()
        {
            #region NonGeneric
            dynamic result = NGMath.Add(2, 3);
            result = NGMath.Add(2.5f, 1.3f);
            result = NGMath.Add(25m, 3m);

            #endregion
            #region Generic
            result = GMath.Add(2, 3);
            result = GMath.Add(2.5f, 1.3f);
            result = GMath.Add(25m, 3m);
            #endregion

            #region Generic Constraints

            var person1 = new Person { FirstName = "person type" };
            var person2 = new Person { FirstName = "not allowed in add" };

            //shows compile time error
            //result = GMath.Add(person1, person2);
            #endregion
            Console.WriteLine(result);
        }
    }
}
