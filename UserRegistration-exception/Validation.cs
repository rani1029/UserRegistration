using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


namespace UserRegistration_exception
{
    public class validation
    {
        const string REGEX_NAME = "^[A-Z]{1}[A-Za-z]{2,}";
        const string REGEX_EMAIL_ID = @"^[A-Za-z0-9]+([\.+\-_][A-Za-z0-9]+)*@[a-zA-Z0-9]+\.?[A-Za-z]+\.?[A-Za-z]{2,}$";
        const string REGEX_MOBILE_NUMBER = "^[1-9]{1,2}[ ][1-9]{1}[0-9]{9}$";
        const string REGEX_PASSWORD = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[~`!@#$%^&*_+=,./?]).{8,}$";

        public void FirstName(string firstName)
        {
            if (Regex.IsMatch(firstName, REGEX_NAME) == false)
                throw new ExceptionHandling(ExceptionHandling.ExceptionsCustomMessage.INVALID_INPUT, " : Name start with Capital and has Minimum 3 characters");
        }
        public void LastName(string lastName)
        {
            if (Regex.IsMatch(lastName, REGEX_NAME) == false)
                throw new ExceptionHandling(ExceptionHandling.ExceptionsCustomMessage.INVALID_INPUT, " : Name start with Capital and has Minimum 3 characters");
        }

        public void Email(string email)
        {
            if (Regex.IsMatch(email, REGEX_EMAIL_ID) == false)
                throw new ExceptionHandling(ExceptionHandling.ExceptionsCustomMessage.INVALID_INPUT, " : Invalid Email-ID");
        }

        public void Mobile(string mobile)
        {
            if (Regex.IsMatch(mobile, REGEX_MOBILE_NUMBER) == false)
                throw new ExceptionHandling(ExceptionHandling.ExceptionsCustomMessage.INVALID_INPUT, " : Invalid Mobile Number");
        }

        public void Password(string password)
        {
            if (Regex.IsMatch(password, REGEX_PASSWORD) == false)
                throw new ExceptionHandling(ExceptionHandling.ExceptionsCustomMessage.INVALID_INPUT, " : Invalid Password");
        }
    }
}
