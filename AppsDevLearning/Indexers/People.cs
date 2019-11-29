using Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Indexers
{
    public class People
    {
        private readonly List<Person> _group = new List<Person>();

        public void Add(Person person) => _group.Add(person);
        public void Add(List<Person> persons) => _group.AddRange(persons);

        public Person this[int phone] => _group.First(p => p.Phone == phone);

        public Person this[string firstName] =>
            _group.FirstOrDefault(p => string.Equals(p.FirstName, firstName, StringComparison.OrdinalIgnoreCase));

        public Person this[string firstName, string lastName] =>
            _group.FirstOrDefault(p => string.Equals(p.FirstName, firstName, StringComparison.OrdinalIgnoreCase)
                                       && string.Equals(p.LastName, lastName, StringComparison.OrdinalIgnoreCase));

        public Person GetPersonByFirstName(string firstName) =>
            _group.FirstOrDefault(p => string.Equals(p.FirstName, firstName, StringComparison.OrdinalIgnoreCase));

        public Person GetPersonByFirstNameAndLastName(string firstName, string lastName) =>
            _group.FirstOrDefault(p => string.Equals(p.FirstName, firstName, StringComparison.OrdinalIgnoreCase)
                                       && string.Equals(p.LastName, lastName, StringComparison.OrdinalIgnoreCase));

    }
}