using HotelTask.Utlis.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelTask.Models
{
    class Hotel
    {
        public string Name { get; set; }
        private Room[] _rooms;
        public Hotel(string name)
        {
            _rooms = new Room[0];
            Name = name;
        }
        //Hotel h = new Hotel()
        //h["adf"]
        public Room this[string key]
        {
            get
            {
                foreach (Room room in _rooms)
                {
                    if (room.Name == key)
                    {
                        return room;
                    }
                }
                throw new NotFoundException();
            }
            set
            {
                int index = -1;
                for (int i = 0; i < _rooms.Length; i++)
                {
                    if (_rooms[i].Name == key)
                    {
                        index = i;
                        break;
                    }
                }
                if (index != -1)
                {
                    _rooms[index] = value;
                }
            }
        }
        public void AddRooms(params Room[] rooms) //3
        {
            int oldLength = _rooms.Length;//5
            Array.Resize(ref _rooms, oldLength + rooms.Length);
            for (int i = oldLength; i <= _rooms.Length-1; i++)
            {
                _rooms[i] = rooms[i-oldLength];
            }
        }
    }
}
