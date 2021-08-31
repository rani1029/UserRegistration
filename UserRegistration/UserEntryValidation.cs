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
            string RegexLastName = "^[A - Z]{ 1}[a-z]{ 2,}$";

            Console.WriteLine("enter valid last name");

            string Lastname = Console.ReadLine();

            bool validation2 = Regex.IsMatch(Lastname, RegexLastName);
            Console.WriteLine("lasttname is valid " + validation2);

        }
    }
}
