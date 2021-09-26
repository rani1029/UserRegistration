using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class UserEntryValidation
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
            //"@^[a-z0-9]+([.]?[\+\-_][a-zA-Z0-9])*[@][a-z0-9]+[\+]?[a-z]+([\.][a-zA-Z])*$"
            const string RegexEmail = "^[a-zA-Z0-9]+[_.]+[.]([a-zA-Z0-9])+[@][a-z]{2}[.][a-zA-Z]{2}[.]([a-zA-Z])+";

            Console.WriteLine("enter valid Email");

            string Email = Console.ReadLine();

            bool validation3 = Regex.IsMatch("Email", RegexEmail);
            Console.WriteLine("Email is valid " + validation3);
        }
        public static void MultipleCheck()
        {
            Console.WriteLine("do u want to enter another email press y or n");
            string UserReply = Console.ReadLine();
            if (UserReply == "y")
            {
                Email();

            }
            else
                Console.WriteLine(" wrong input");

        }

        public static void PhoneNumber()
        {
            const string RegexPhoneNumber = "^[1-9]{1,2}[ ][1-9]{1}[0-9]{9}$";

            Console.WriteLine("enter valid PhoneNumber");

            string PhoneNumber = Console.ReadLine();

            bool validation2 = Regex.IsMatch(PhoneNumber, RegexPhoneNumber);
            Console.WriteLine("PhoneNumber is valid " + validation2);

        }
        //method to check pattern for password of minimum 8 charactor
        public static void PassWord()
        {
            const string RegexPassword = @"^[A-Z0-9a-z@!#$%&*+?]{8,25}$";
            Console.WriteLine("enter  Password");
            string Password = Console.ReadLine();
            bool Passwordvalidation = Regex.IsMatch(Password, RegexPassword);
            Console.WriteLine(" Password is valid :" + Passwordvalidation);
        }
    }
}



