using Meeting_Scheduling_System.ModelTrusted;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meeting_Scheduling_System.ControllerTrusted
{
    internal static class ComplaintController
    {
        private static Complaint currentComplaint;
        private static List<Complaint> complaintList;

        public static void addComplaint(Complaint complaint)
        {
            //pulls data from untrusted controller and runs complaint constructor and adds to list
        }

        public static void removeComplaint(Complaint complaint)
        {
            complaintList.Remove(complaint);
        }

        public static void respondToComplaint()
        {
            //do something with current complaint
            currentComplaint.IsReviewed = true;
        }

        public static void showComplaints()
        {
            //show in ui
        }
    }
}
