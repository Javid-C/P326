using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork08._15._2022.Models
{
    class Song
    {
        private string _name;
        private string _genre;
        private int[] _raitings;
        public Song()
        {
            _raitings = new int[0];
        }
        public string Name
        {
            get { return _name; }
            set {
                if (value.Length <= 100)
                {
                    _name = value;
                }
            }
        }
        public string Genre
        {
            get { return _genre; }
            set {
                switch (value)
                {
                    case "Pop":
                    case "Rock":
                    case "Jazz":
                    case "Techno":
                        _genre = value; 
                        break;
                    default:
                        break;
                }
            }
        }
        public Singer Singer { get; set; }
        public void AddRaiting(int raiting)
        {
            if (raiting <=10 && raiting >=0)
            {
                Array.Resize(ref _raitings,_raitings.Length+1);
                _raitings[_raitings.Length - 1] = raiting;
            }
        }

        public float GetAverageRating()
        {
            float sum = 0;
            foreach (int item in _raitings)
            {
                sum += item;
            }
            if (sum / _raitings.Length is float.NaN)
            {
                return 0;
            }
            else
            {
                return sum / _raitings.Length;
            }
        }
    }
}
