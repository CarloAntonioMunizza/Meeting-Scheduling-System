using Meeting_Scheduling_System.ModelTrusted;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meeting_Scheduling_System.ControllerTrusted
{
    internal class BillingController
    {
        public void updateBillingInfo(Account account, BillingInfo billing)
        {
            //update billinginfo for account, data pushed from untrusted and then updated in model
        }

        public void payBill(Account account, Meeting meeting)
        {
            if (!meeting.Paid)
            {
                account.Balance -= 100;
            }
        }
    }
}
