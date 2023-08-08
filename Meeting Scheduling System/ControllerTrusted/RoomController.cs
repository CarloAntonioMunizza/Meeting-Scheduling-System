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

        public static void addRoom(Room room)
        {
            //room is supplied from untrusted controller when admin is entering data for new room
            rooms.Add(room);
        }

        public static void removeRoom(Room room)
        {
            //room is selected from ui
            rooms.Remove(room);
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
