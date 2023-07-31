using Meeting_Scheduling_System.ModelTrusted;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meeting_Scheduling_System.ControllerTrusted
{
    internal class MeetingController
    {
        private Meeting currentMeeting;
        private List<Meeting> meetingList = new List<Meeting>();

        public void addUser(Account a)
        {
            //if participant is not in another meeting
            currentMeeting.Participants.Add(a);
            //else yell at them
        }

        public void removeUser(Account a)
        {
            currentMeeting.Participants.Remove(a);
        }

        public void changeTime(DateTime time) 
        {
            if (checkAvailability(currentMeeting.Room, time))
            {
                currentMeeting.Time = time;
            }
            //else yell
            
        }

        public void changeRoom (Room room)
        {
            if (checkAvailability(room, currentMeeting.Time )) {
                currentMeeting.Room = room;
            }
            //else yell
        }

        public void getMeetingInfo(Meeting meeting) 
        { 
            //push data of meeting to form group window
        }

        public bool checkAvailability(Room room, DateTime time)
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
