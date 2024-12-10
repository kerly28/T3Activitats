using System;

namespace T3Activitats
{
    public class Room
    {
        public int RoomNumber { get; set; }
        public string Type { get; set; }

        public Room(int roomNumber, string type)
        {
            RoomNumber = roomNumber;
            Type = type;
        }
    }
}
