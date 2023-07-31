using Meeting_Scheduling_System.ModelTrusted;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meeting_Scheduling_System.ControllerTrusted
{
    internal class ComplaintController
    {
        private Complaint currentComplaint;
        private List<Complaint> complaintList;

        public void addComplaint(Complaint complaint)
        {
            //pulls data from untrusted controller and runs complaint constructor and adds to list
        }

        public void removeComplaint(Complaint complaint)
        {
            complaintList.Remove(complaint);
        }

        public void respondToComplaint()
        {
            //do something with current complaint
            currentComplaint.IsReviewed = true;
        }

        public void showComplaints()
        {
            //show in ui
        }
    }
}
