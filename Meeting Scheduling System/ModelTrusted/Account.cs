using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meeting_Scheduling_System.ModelTrusted
{
    internal class Account : Admin
    {
        //initialize variables
        private string firstName, lastName, email, password,securityA;
        private List<Meeting> meetings = new List<Meeting>();
        private BillingInfo paymentMethod;
        private int balance = 0;
        private bool isAdmin = false;

        //basic constructor for a new account
        public Account(string firstName, string lastName, string email, string password, string securityA)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.password = password;
            this.securityA = securityA;
        }

        //setters / getters
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string SecurityA { get => securityA; set => securityA = value; }
        public int Balance { get => balance; set => balance = value; }
        internal List<Meeting> Meetings { get => meetings; set => meetings = value; }
        internal BillingInfo PaymentMethod { get => paymentMethod; set => paymentMethod = value; }
    }
}
