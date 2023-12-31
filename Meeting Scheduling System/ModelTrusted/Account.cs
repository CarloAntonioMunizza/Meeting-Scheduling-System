﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meeting_Scheduling_System.ModelTrusted
{
    internal class Account : Admin
    {
        //initialize variables
        private string firstName, lastName, email, password, securityA;
        private List<Meeting> meetings = new List<Meeting>();
        private BillingInfo paymentMethod;
        private int balance;
        private bool isAdmin;
        private Complaint complaint;

        //basic constructor for a new account
        public Account(string firstName, string lastName, string email, string password, string securityA)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.password = password;
            this.securityA = securityA;
            complaint = new Complaint("", this, false);
        }

        //setters / getters
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string SecurityA { get => securityA; set => securityA = value; }
        public int Balance { get => balance; set => balance = value; }
        public bool IsAdmin { get => isAdmin; set => isAdmin = value; }
        internal List<Meeting> Meetings { get => meetings; set => meetings = value; }
        internal BillingInfo PaymentMethod { get => paymentMethod; set => paymentMethod = value; }
        internal Complaint Complaint { get => complaint; set => complaint = value; }

        public static explicit operator Account(int v)
        {
            throw new NotImplementedException();
        }
    }
}
