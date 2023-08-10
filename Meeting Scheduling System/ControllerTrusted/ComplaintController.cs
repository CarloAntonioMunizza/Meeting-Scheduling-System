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
        private static List<Complaint> complaintList = new List<Complaint>();

        internal static Complaint CurrentComplaint { get => currentComplaint; set => currentComplaint = value; }
        internal static List<Complaint> ComplaintList { get => complaintList; set => complaintList = value; }


        public static void fill()
        {
            Complaint complaint1 = new Complaint("This app is boring.", AccountController.Accounts[0], false);
            Complaint complaint2 = new Complaint("Need more color.", AccountController.Accounts[1], false);
            Complaint complaint3 = new Complaint("My rooms are boooring.", AccountController.Accounts[3], true);
            complaint3.Response = "I am terribly sorry about that. We will strive to do better!";

            AccountController.Accounts[0].Complaint = complaint1;
            AccountController.Accounts[1].Complaint = complaint2;
            AccountController.Accounts[3].Complaint = complaint3;

            complaintList.Add(complaint1);
            complaintList.Add(complaint2);
            complaintList.Add(complaint3);

         
        }

        public static void addComplaint(string message)
        {
            //pulls data from untrusted controller and runs complaint constructor and adds to list
            Complaint complaint = new Complaint(message, AccountController.CurrentAccount, false);
            complaintList.Add(complaint);
            AccountController.CurrentAccount.Complaint = complaint;
        }

        public static void removeComplaint(Complaint complaint)
        {
            ComplaintList.Remove(complaint);
        }

        public static void respondToComplaint(Complaint complaint)
        {
            complaint.IsReviewed = true;
        }

        public static void showComplaints()
        {
            //show in ui
        }
    }
}
