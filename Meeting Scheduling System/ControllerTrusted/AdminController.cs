﻿using Meeting_Scheduling_System.ModelTrusted;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meeting_Scheduling_System.ControllerTrusted
{
    internal static class AdminController 
    {
        private static Admin currentAdmin;

        public static void createAdmin()
        {
            //pulls data from untrusted controller and populates an account constructor as an admin
        }

        public static void updateOtherBilling(Account a)
        {
            //updates another user's billingInfo entered from untrusted controller and pushes to account
        }
    }
}
