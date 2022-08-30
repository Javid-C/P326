using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Access_Modifiers.Models
{
    class User
    {
        private string _username;
        private string _password;
        public const string Fin = "asjkdhasjhd";
        //public string Fin { get; }

        public string Username {
            get {
                return _username;
            }
            set {
                if (value.Length >= 6 && value.Length <=25 )
                {
                    _username = value;
                }
            }
        }
        public string Password { 
            get {
                return _password;
            }
            set {
                if (value.Length >= 8 && value.Length <=25 && HasDigit(value) && HasUpper(value) && HasLower(value))
                {
                    _password = value;
                }
            }
        }
        public User()
        {
            //Fin = "irhifh";
        }
        public User(string username)
        {
            Username = username;
            //Name = "Ceyhun";
        }
        
        bool HasDigit(string str)
        {
            string a = Fin;
            foreach (char item in str)
            {
                if (Char.IsDigit(item))
                {
                    return true;
                }
            }
            return false;
        }
        bool HasLower(string str)
        {
            foreach (char item in str)
            {
                if (Char.IsLower(item))
                {
                    return true;
                }
            }
            return false;
        }
        bool HasUpper(string str)
        {
            foreach (char item in str)
            {
                if (Char.IsUpper(item))
                {
                    return true;
                }
            }
            return false;
        }

    }
}
