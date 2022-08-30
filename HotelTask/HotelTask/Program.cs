using HotelTask.Models;
using System;

namespace HotelTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Room r1 = new Room("Sirius", 50,4);
            Room r3 = new Room("Neptune", 100,10);
            Hotel code = new Hotel("Code Hotelademy");
            code.AddRooms(r1,r3);
            Room asd = new Room("ASD",500,20);
            code["Neptune"] = asd;
            Console.WriteLine(code["ASD"]);
        }
    }
}
