using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers.Models
{
    class Vehicle
    {
        //private - yalniz oz class-i daxlinde elcatandir. Class Memberlarin default access modifier-idir.
        //private string Color;
        public int Year;
        //protected - hem oz classi daxilinde hem de miras verdiyi class daxilinde el catandir - class members-e aiddir
        //protected string Color;

        //internal, public -  classlara, interfacelere, class memberlere verilir.
        //internal - 1 projectde hem oz classinda, hem miras alinan classda hem de instance alinan obyektde elcatandir
        //public - reference alan projectlerde de ...(internalla eyni)
        internal string Color;

        public Vehicle()
        {

        }
        public Vehicle(int Year)
        {
            this.Year = Year;
        }
        private void Test()
        {
            Color = "Orange";
        }
        public void ColorInfo()
        {
            Console.WriteLine(Color);
        }
    }
}
