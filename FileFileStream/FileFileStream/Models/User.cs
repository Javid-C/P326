using System;
using System.Collections.Generic;
using System.Text;

namespace FileFileStream.Models
{
    internal class User
    {
        private static int _id;
        public int Id { get; }
        public string Username { get; set; }
        public string Password { get; set; }
        public User()
        {
            _id++;
            Id = _id;
        }
    }
}
