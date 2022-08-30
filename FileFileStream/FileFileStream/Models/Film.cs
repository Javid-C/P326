using System;
using System.Collections.Generic;
using System.Text;

namespace FileFileStream.Models
{
    internal class Film
    {
        private static int _id;
        public int Id { get; }
        public string Name { get; set; }
        public Film()
        {
            _id++;
            Id = _id;
        }
    }
}
