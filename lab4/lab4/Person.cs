using System;
using System.Collections.Generic;
using System.Text;

namespace lab4
{
    class Person
    {
        private string fullName;
        public string FullName
        {
            get
            {
                return fullName;
            }
            set
            {
                fullName = value;
            }
        }

        private string adressLine;
        public string AdressLine
        {
            get
            {
                return adressLine;
            }
            set
            {
                adressLine = value;
            }
        }

        private string phoneNumber;
        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                phoneNumber = value;
            }
        }

    }
}
