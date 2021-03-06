using Bogus;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab4
{
    class PeopleInitializer
    {
        private long numOfPeople;
        private string locale;
        public PeopleInitializer(long numOfPeople, string locale)
        {
            this.numOfPeople = numOfPeople;
            this.locale = locale;
        }
        public List<Person> Initialization()
        {
            var dataCreator = new Faker<Person>(locale)
                .RuleFor(x => x.FullName, f => f.Name.FullName())
                .RuleFor(x => x.AdressLine, f => f.Address.FullAddress())
                .RuleFor(x => x.PhoneNumber, f => f.Phone.PhoneNumber());
            List<Person> people = new List<Person>();
            for (long i = 0; i < numOfPeople; i++)
            {
                Person person = dataCreator.Generate();
                people.Add(person);
            }
            return people;
        }
    }
}
