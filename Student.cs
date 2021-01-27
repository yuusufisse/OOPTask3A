using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace OOPTask3A
{
    class Student
    {
        // Constructor with 3 parameters
        public Student(string firstName, string familyName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            FamilyName = familyName;
            DateOfBirth = dateOfBirth;
        }

        public string FirstName { get; set; }
        public string FamilyName { get; set; }
        //Proberty with backing field 
        private DateTime _dateOfBirth;
        public DateTime DateOfBirth
        {
            get
            {
                return _dateOfBirth;
            }
            set
            {
                if (value <= new DateTime(1900, 1, 1))
                    value = new DateTime(1900, 1, 1);
                _dateOfBirth = value;
            }
        }

        public override string ToString()
        {
            //You can define here...
            CultureInfo culture = new CultureInfo("fi-FI");
            return $"Firstname is {FirstName}, Family name is {FamilyName}, " +
                $"Birthday is {string.Format(culture,"{0:D}", DateOfBirth)}";
        }

    }

}
