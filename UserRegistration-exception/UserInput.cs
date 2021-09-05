using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


namespace UserRegistration_exception
{
    public class UserInput
    {
        Validation validation = new Validation();

        //Constructor
        public UserInput()
        {

            Console.WriteLine("\nEnter Number To do Operation : ");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Press 1. -> First Name Validation");
            Console.WriteLine("Press 2. -> Last Name Validation");
            Console.WriteLine("Press 3. -> Email-ID Validation");
            Console.WriteLine("Press 4. -> Password Validation");
            Console.WriteLine("Press 5. -> Mobile Number Validation");
            Console.WriteLine("Press 0. -> Exit");
            Console.WriteLine("------------------------------------");


            int userChoice = int.Parse(Console.ReadLine());

            switch (userChoice)
            {
                case 1: //First Name
                    Console.WriteLine("Enter the First name :");
                    string firstName = Console.ReadLine();
                    FirstName(firstName);
                    UserInput userInput1 = new UserInput();
                    break;

                case 2: //Last Name
                    Console.WriteLine("Enter the last name :");
                    string lastName = Console.ReadLine();
                    LastName(lastName);
                    UserInput userInput2 = new UserInput();
                    break;

                case 3: //Email-ID
                    Console.WriteLine("Enter Email-ID  :");
                    string email = Console.ReadLine();
                    Email(email);
                    UserInput userInput3 = new UserInput();
                    break;

                case 4: //Password
                    Console.WriteLine("Enter Password :");
                    string passWord = Console.ReadLine();
                    Password(passWord);
                    UserInput userInput4 = new UserInput();
                    break;

                case 5: //Mobile Number
                    Console.WriteLine("Enter Mobile number :");
                    string mobileNumber = Console.ReadLine();
                    Mobile(mobileNumber);
                    UserInput userInput5 = new UserInput();
                    break;

                case 6: //Exit
                    System.Environment.Exit(0);
                    break;

                default:
                    //Console.WriteLine("Invalid Input !!!");
                    break;
            }
        }

        public void FirstName(string firstName)
        {
            try
            {
                if (validation.FirstName(firstName, Validation.REGEX_NAME) == true)
                    Console.Write("Valid First Name : " + firstName);
                else
                    throw new ExceptionHandling(ExceptionHandling.ExceptionsCustomMessage.INVALID_INPUT, "Name start with Capital and has Minimum 3 characters");
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid Input :");
                Console.WriteLine(e.Message);
            }
        }
        public void LastName(string lastName)
        {
            try
            {
                if (validation.LastName(lastName, Validation.REGEX_NAME) == true)
                    Console.Write("Valid LastName : " + lastName);
                else
                    throw new ExceptionHandling(ExceptionHandling.ExceptionsCustomMessage.INVALID_INPUT, "Name start with Capital and has Minimum 3 characters");
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid Input :");
                Console.WriteLine(e.Message);
            }
        }
        public void Email(string email)
        {
            try
            {
                if (validation.Email(email, Validation.REGEX_EMAIL_ID) == true)
                    Console.Write("Valid Email-Id : " + email);
                else
                    throw new ExceptionHandling(ExceptionHandling.ExceptionsCustomMessage.INVALID_INPUT, "Invalid Email-ID");
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid Input :");
                Console.WriteLine(e.Message);
            }

        }

        public void Password(string password)
        {
            try
            {
                if (validation.Password(password, Validation.REGEX_PASSWORD) == true)
                    Console.Write("Valid Password : " + password);
                else
                    throw new ExceptionHandling(ExceptionHandling.ExceptionsCustomMessage.INVALID_INPUT, " : Invalid Password");
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid Input :");
                Console.WriteLine(e.Message);
            }
        }

        public void Mobile(string mobile)
        {
            try
            {
                if (validation.MobileNumber(mobile, Validation.REGEX_MOBILE_NUMBER) == true)
                    Console.Write("Valid Mobile Number : " + mobile);
                else
                    throw new ExceptionHandling(ExceptionHandling.ExceptionsCustomMessage.INVALID_INPUT, "Invalid Mobile Number");
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid Input :");
                Console.WriteLine(e.Message);
            }

        }
    }
}
