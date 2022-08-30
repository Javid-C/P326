using HomeWork16._08._2022.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork16._08._2022.Models.Classes
{
    class Square:Figure
    {
        public double Side { get; set; }
        public Square(double side)
        {
            Side = side;
        }
        public override double CalcArea()
        {
            return Side * Side;
        }
    }
}
