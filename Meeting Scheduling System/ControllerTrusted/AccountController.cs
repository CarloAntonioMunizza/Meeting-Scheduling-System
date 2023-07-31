using Meeting_Scheduling_System.ModelTrusted;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meeting_Scheduling_System.ControllerTrusted
{
    internal class AccountController
    {
        private Account currentAccount;
        private List<Account> accounts;

        public void Createuser()
        {
            //creates a user from form, assume pulling data from untrusted controller then using the Account constructor
        }

        public void getAccountInfo(Account account)
        {
            //pulls data from the account's params's gets and puts to form
        }

        public void updateAccountInfo(Account account) 
        {
            //pulls data from untrusted controller with user entered data and sets params to account
        }

        public void setPaymentMethod (Account account, BillingInfo payment)
        {
            //pulls data from the BillingInfo controller when creating a new payment method and assigns to the account
        }
        public void getPaymentMethod(Account account) 
        {
            //pulls data from the account and shows the payment info
        }
    }
}
