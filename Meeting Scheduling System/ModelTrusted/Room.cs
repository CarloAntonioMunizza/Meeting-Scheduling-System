namespace Meeting_Scheduling_System.ModelTrusted
{
    public class Room
    {
        //define vars
        private int roomNumber;
        private List<Meeting> meetingList;
        private bool isSpecial, isOccupied;

        public Room(int roomNumber, bool isSpecial)
        {
            this.roomNumber = roomNumber;
            this.isSpecial = isSpecial;
            this.meetingList = new List<Meeting>();
            this.isOccupied = false;
        }

        public int RoomNumber { get => roomNumber; set => roomNumber = value; }
        public bool IsSpecial { get => isSpecial; set => isSpecial = value; }
        public bool IsOccupied { get => isOccupied; set => isOccupied = value; }
        internal List<Meeting> MeetingList { get => meetingList; set => meetingList = value; }
    }
}