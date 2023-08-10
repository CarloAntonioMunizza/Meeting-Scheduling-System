using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meeting_Scheduling_System.ModelTrusted
{
    internal class Complaint
    {
        //define vars
        private string message, response;
        private Account sender;
        private bool isReviewed;
        

        //constructor
        public Complaint(string message, Account sender, bool isReviewed)
        {
            this.message = message;
            this.sender = sender;
            this.isReviewed = isReviewed;
        }
        //setters / getters
        public string Message { get => message; set => message = value; }
        public bool IsReviewed { get => isReviewed; set => isReviewed = value; }
        public string Response { get => response; set => response = value; }
        internal Account Sender { get => sender; set => sender = value; }
    }
}
