using Meeting_Scheduling_System.ModelTrusted;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meeting_Scheduling_System.ControllerTrusted
{
    internal static class RoomController
    {
        private static Room currentRoom;
        private static List<Room> rooms = new List<Room>();

        public static Room CurrentRoom { get => currentRoom; set => currentRoom = value; }
        public static List<Room> Rooms { get => rooms; set => rooms = value; }

        //prefill rooms for demo

        public static void fill()
        {
            Rooms.Add(new Room(101, false));
            Rooms.Add(new Room(102, false));
            Rooms.Add(new Room(103, false));
            Rooms.Add(new Room(104, false));
            Rooms.Add(new Room(105, true));

        }

        public static void addRoom(Room room)
        {
            //room is supplied from untrusted controller when admin is entering data for new room
            Rooms.Add(room);
        }

        public static void removeRoom(Room room)
        {
            //room is selected from ui
            Rooms.Remove(room);
        }

        public static bool checkOccupied(Room room, DateTime time)
        {
            //if foreach room.MeetingList.Contains a meeting for the time 
            //return true;

            //else
            return false;
        }
    }
}
