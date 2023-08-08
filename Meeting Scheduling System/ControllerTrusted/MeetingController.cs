using Meeting_Scheduling_System.ModelTrusted;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meeting_Scheduling_System.ControllerTrusted
{
    internal static class MeetingController
    {
        private static Meeting currentMeeting;
        private static List<Meeting> meetingList = new List<Meeting>();

        public static void addUser(Account a)
        {
            //if participant is not in another meeting
            currentMeeting.Participants.Add(a);
            //else yell at them
        }

        public static void removeUser(Account a)
        {
            currentMeeting.Participants.Remove(a);
        }

        public static void changeTime(DateTime time) 
        {
            if (checkAvailability(currentMeeting.Room, time))
            {
                currentMeeting.Time = time;
            }
            //else yell
            
        }

        public static void changeRoom (Room room)
        {
            if (checkAvailability(room, currentMeeting.Time )) {
                currentMeeting.Room = room;
            }
            //else yell
        }

        public static void getMeetingInfo(Meeting meeting) 
        { 
            //push data of meeting to form group window
        }

        public static bool checkAvailability(Room room, DateTime time)
        {
            foreach (Meeting meeting in meetingList)
            {
                if (meeting.Time == time && meeting.Room == room) 
                {
                    return false;
                }
            }
            return true;
        }


    }
}
