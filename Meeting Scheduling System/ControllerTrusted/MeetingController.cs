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
        static List<String> timeList = new List<String>();

        public static List<string> TimeList { get => timeList; set => timeList = value; }
        internal static Meeting CurrentMeeting { get => currentMeeting; set => currentMeeting = value; }
        internal static List<Meeting> MeetingList { get => meetingList; set => meetingList = value; }

        static MeetingController()
        {
            fillTimes();
        }
        public static void fillTimes()
        {
            timeList.Add("9:00 - 10:00");
            timeList.Add("10:00 - 11:00");
            timeList.Add("11:00 - 12:00");
            timeList.Add("12:00 - 1:00");
            timeList.Add("1:00 - 2:00");
            timeList.Add("2:00 - 3:00");
            timeList.Add("3:00 - 4:00");
            timeList.Add("4:00 - 5:00");
        }

        public static void createMeeting(Room room, String time, List<Account> participants, Account host)
        {
            Meeting meeting = new Meeting(room, time, participants, host);
            foreach (var participant in participants)
            {
                //need to check if they're available tho
                participant.Meetings.Add(meeting);
            }
            MeetingList.Add(meeting);
        }
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

        public static void changeTime(string time) 
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

        public static bool checkAvailability(Room room, string time)
        {
            foreach (Meeting meeting in meetingList)
            {
                if (meeting.Time.Equals( time) && meeting.Room == room) 
                {
                    return false;
                }
            }
            return true;
        }


    }
}
