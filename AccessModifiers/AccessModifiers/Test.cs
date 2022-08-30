using AccessModifiers.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers
{
    class Test:Vehicle
    {
        public void A()
        {
            Car v = new Car();
            Color = "Orange";
        }
    }
}
