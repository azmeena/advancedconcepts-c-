using System;
using System.Collections.Generic;
using Common;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            Scorecard scorecard = new Scorecard();
            scorecard.Add("Player1", 10);
            scorecard.Add("Player2", 15);
            int expectedScore = 15;
            int actualScore = scorecard["Player2"];
            Console.WriteLine($"Expected score is: {expectedScore}, Actual score is: {actualScore}");

            var people = new People();
            people.Add(new List<Person> {
                new Person{FirstName= "colin",LastName = "roy",Phone = 000},
                new Person{FirstName= "mark",LastName = "heath",Phone = 111},
                new Person{FirstName= "joe",LastName = "mcgrath",Phone = 222}
            });

            #region without indexer

            var person1 = people.GetPersonByFirstNameAndLastName("mark", "heath")?.FirstName;

            var person2 = people.GetPersonByFirstName("colin")?.FirstName;

            #endregion

            #region Indexer 

            var person3 = people["mark", "heath"]?.FirstName;
            var person4 = people["roy"]?.FirstName;
            var person5 = people[222]?.FirstName;

            Console.WriteLine(person1 + ", " + person2 + ", " + person3 + ", " + person4 + ", " + person5);
            #endregion
            Console.ReadLine();

        }
    }
}
