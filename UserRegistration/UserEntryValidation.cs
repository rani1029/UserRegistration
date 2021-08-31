using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class UserEntryValidation
    {
        public static void FirstName()
        {
            string RegexFirstName = "^[A - Z]{ 1}[a-z]{ 2,}$";

            Console.WriteLine("enter valid first name");

            string Firstname = Console.ReadLine();

            bool validation = Regex.IsMatch(Firstname, RegexFirstName);
            Console.WriteLine("firstname is valid " + validation);

        }

        public static void LastName()
        {
            const string RegexLastName = "^[A - Z]{ 1}[a-z]{ 2,}$";

            Console.WriteLine("enter valid last name");

            string Lastname = Console.ReadLine();

            bool validation2 = Regex.IsMatch(Lastname, RegexLastName);
            Console.WriteLine("lasttname is valid " + validation2);

        }

        public static void Email()
        {
            const string RegexEmail = "^[a-zA-Z0-9]+[_.]+[.]([a-zA-Z0-9])+[@][a-z]{2}[.][a-zA-Z]{2}[.]([a-zA-Z])+$";

            Console.WriteLine("enter valid Email");

            string Email = Console.ReadLine();

            bool validation3 = Regex.IsMatch("Email", RegexEmail);
            Console.WriteLine("Email is valid " + validation3);

        }

        public static void PhoneNumber()
        {
            const string RegexPhoneNumber = "^[1-9]{1,2}[ ][1-9]{1}[0-9]{9}$";

            Console.WriteLine("enter valid PhoneNumber");

            string PhoneNumber = Console.ReadLine();

            bool validation2 = Regex.IsMatch(PhoneNumber, RegexPhoneNumber);
            Console.WriteLine("PhoneNumber is valid " + validation2);

        }


    }
}