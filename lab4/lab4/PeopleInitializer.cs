using Bogus;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab4
{
    class PeopleInitializer
    {
        private int numOfPeople;
        private string locale;
        public PeopleInitializer(int numOfPeople, string locale)
        {
            this.numOfPeople = numOfPeople;
            this.locale = locale;
        }
        public string Initialization()
        {
            var dataCreator = new Faker<Person>(locale)
                .RuleFor(x => x.FullName, f => f.Name.FullName())
                .RuleFor(x => x.AdressLine, f => f.Address.FullAddress())
                .RuleFor(x => x.PhoneNumber, f => f.Phone.PhoneNumber());
            string csvstring="";
            for (int i = 0; i < numOfPeople; i++)
            {
                Person person = dataCreator.Generate();
                csvstring += String.Format("{0};{1};{2}\n", PeopleInitializer.StringToCSVCell(person.FullName), PeopleInitializer.StringToCSVCell(person.AdressLine), PeopleInitializer.StringToCSVCell(person.PhoneNumber));
                
            }
            return csvstring;
        }
        public static string StringToCSVCell(string str)
        {
            bool mustQuote = (str.Contains(",") || str.Contains("\"") || str.Contains("\r") || str.Contains("\n"));
            if (mustQuote)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("\"");
                foreach (char nextChar in str)
                {
                    sb.Append(nextChar);
                    if (nextChar == '"')
                        sb.Append("\"");
                }
                sb.Append("\"");
                return sb.ToString();
            }

            return str;
        }
    }
}
