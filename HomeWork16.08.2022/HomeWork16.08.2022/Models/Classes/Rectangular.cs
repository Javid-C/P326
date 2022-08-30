using HomeWork16._08._2022.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork16._08._2022.Models.Classes
{
    class Rectangular:Figure
    {
        public double Width { get; set; }
        public double Length { get; set; }
        public Rectangular(double width, double length)
        {
            Width = width;
            Length = length;
        }

        public override double CalcArea()
        {
            return Width * Length;
        }
    }
}
