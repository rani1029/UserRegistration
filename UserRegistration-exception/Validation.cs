using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


namespace UserRegistration_exception
{
    public class Validation
    {
        const string REGEX_NAME = "^[A-Z]{1}[A-Za-z]{2,}";
        const string REGEX_EMAIL_ID = @"^[A-Za-z0-9]+([\.+\-_][A-Za-z0-9]+)*@[a-zA-Z0-9]+\.?[A-Za-z]+\.?[A-Za-z]{2,}$";
        const string REGEX_MOBILE_NUMBER = "^[1-9]{1,2}[ ][1-9]{1}[0-9]{9}$";
        const string REGEX_PASSWORD = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[~`!@#$%^&*_+=,./?]).{8,}$";


        //Lamda Functions
        public Func<string, string, bool> FirstName = (firstName, regexFirstName) => Regex.IsMatch(firstName, regexFirstName);
        public Func<string, string, bool> LastName = (lastName, regexLastName) => Regex.IsMatch(lastName, regexLastName);
        public Func<string, string, bool> Email = (email, regexEmail) => Regex.IsMatch(email, regexEmail);
        public Func<string, string, bool> MobileNumber = (mobile, regexMobile) => Regex.IsMatch(mobile, regexMobile);
        public Func<string, string, bool> Password = (password, regexPassword) => Regex.IsMatch(password, regexPassword);
    }
}

