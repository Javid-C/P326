using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers.Models
{
    class Car:Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        private float _fuelCapacity;
        public float FuelCapacity {
            get {
                    return _fuelCapacity;
                }
            set { 
                if(value > 0)
                {
                    _fuelCapacity = value;
                }
            } 
        }

        //public float getFuelCapacity()
        //{
        //    return _fuelCapacity;
        //}
        //public void setFuelCapacity(float fuelCapacity)
        //{
        //    if (fuelCapacity >= 0)
        //    {
        //        _fuelCapacity = fuelCapacity;
        //    }
        //}
        public float FuelFor1KM;
        public float CurrentFuel;
        public Car()
        {

        }
        public Car(string Model, string Brand, float FuelCapacity, float FuelFor1KM, int Year):base(Year)
        {
            this.Brand= Brand;
            this.FuelFor1KM = FuelFor1KM;
            this.FuelCapacity = FuelCapacity;
            this.Model = Model;
            Color = "Red";
            Year = 2022;
        }
        public void ShowInfo()
        {
            Console.WriteLine($@"Brand : {Brand}
Model: {Model}
Current Fuel: {CurrentFuel}");
        }
        public float CanDrive(float path)
        {
            float RequiredFuel = path * FuelFor1KM;
            if (RequiredFuel <= CurrentFuel)
            {
                return CurrentFuel - RequiredFuel;
            }
            return -1;
        }

       
    }
}
