using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Meeting_Scheduling_System.ModelTrusted
{
    internal class Meeting
    {
        //define vars
        private Room room;
        private string time;
        private List<Account> participants = new List<Account>();
        private Account host;
        bool paid = true;

        //constructor
        public Meeting(Room room, string time, List<Account> participants, Account host)
        {
            this.room = room;
            if (room.IsSpecial) { paid = false; }
            this.time = time;
            this.participants = participants;
            this.host = host;
        }

        //setters / getters
        public Room Room { get => room; set => room = value; }
        public string Time { get => time; set => time = value; }
        public bool Paid { get => paid; set => paid = value; }
        internal List<Account> Participants { get => participants; set => participants = value; }
        internal Account Host { get => host; set => host = value; }

        



    }
}