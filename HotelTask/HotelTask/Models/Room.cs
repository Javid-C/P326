using System;
using System.Collections.Generic;
using System.Text;

namespace HotelTask.Models
{
    class Room
    {
        private static int _id;
        public int Id { get; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int PersonCapacity { get; set; }
        public bool IsAvailable { get; set; } = true;

        public Room(string name, decimal price, int personCapacity)
        {
            _id++;
            Id = _id;
            Name = name;
            Price = price;
            PersonCapacity = personCapacity;
        }
        public string ShowInfo()
        {
            return $"{Id}. {Name} - {PersonCapacity} {Price}$ | {(IsAvailable ? "Bosh" : "Dolu" )}";
        }
        public override string ToString()
        {
            return ShowInfo();
        }
    }
}
