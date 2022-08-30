using AccessModifiers.Models;
using System;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Car gls63 = new Car("GLS 63", "Mercedes", 80f, 0.172f, 2022);
            //gls63.CurrentFuel = 70;
            //gls63.ColorInfo();
            //gls63.ColorI = "asd";
            ////gls63.Test();
            //gls63.ColorInfo();
            //gls63.ShowInfo();
            //float result = gls63.CanDrive(400);
            //if (result == -1)
            //{
            //    Console.WriteLine("Bu yolu gede bilmir");
            //}
            //else
            //{
            //    Console.WriteLine(result);
            //}
            //Console.WriteLine(gls63.Color);
            //Vehicle v = new Vehicle();
            //v.Color = "aksdh";
            //int fuelC = Convert.ToInt32(Console.ReadLine());
            //if (fuelC > 0)
            //{
            //    gls63.FuelCapacity = fuelC;
            //}
            gls63.FuelCapacity = 55;
            Console.WriteLine(gls63.FuelCapacity);
        }

    }
}
