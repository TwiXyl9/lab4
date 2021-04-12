﻿using Bogus;
using ServiceStack.Text;
using System;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            int n = 0;
            string locale;
            try
            {
                n = Convert.ToInt32(args[0]);
            }
            catch
            {
                throw new Exception("The first parameter must be an integer!");
            }
            if (n <= 0)
            {
                throw new Exception("The first parameter must be greater than zero!");
            }
            if(args[1] == "en_US" || args[1] == "ru_RU" || args[1] == "uk_UA")
            {
                locale = args[1].Substring(0,2);
                PeopleInitializer peopleInitializer = new PeopleInitializer(n, locale);
                Console.WriteLine(peopleInitializer.Initialization());
            }
            else
            {
                throw new Exception("The second parameter is not correct!You should use en_US, ru_RU or uk_UA");
            }   
        }
    }
}
