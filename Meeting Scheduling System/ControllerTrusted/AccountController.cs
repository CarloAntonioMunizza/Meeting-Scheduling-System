using Meeting_Scheduling_System.ModelTrusted;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meeting_Scheduling_System.ControllerTrusted
{
    internal static class AccountController
    {
        private static Account currentAccount;
        private static List<Account> accounts = new List<Account>();



        public static bool verifySignUpPassword(string password1, string password2)
        {
            bool containsAtLeastOneUppercase = password1.Any(char.IsUpper);
            bool containsAtLeastOnelowerCase = password1.Any(char.IsLower);
            bool containsAtLeastOneDigit = password1.Any(char.IsDigit);
            bool passwordsMatch = password1.Equals(password2);
            bool atLeast6 = password1.Length >= 6;

            if(!containsAtLeastOneDigit || !containsAtLeastOneUppercase|| !containsAtLeastOnelowerCase || !passwordsMatch || !atLeast6) 
            {
                return false;
            }
            return true;
        }

        public static void Createuser(string firstname, string lastname, string email, string password, string sq)
        {
            //creates a user from form, assume pulling data from untrusted controller(view) then using the Account constructor
            Account account = new Account(firstname, lastname, email, password, sq);
            accounts.Add(account);
            currentAccount = account;

        }

        public static void getAccountInfo(Account account)
        {
            //pulls data from the account's params's gets and puts to form
        }

        public static void updateAccountInfo(Account account) 
        {
            //pulls data from untrusted controller with user entered data and sets params to account
        }

        public static void setPaymentMethod (Account account, BillingInfo payment)
        {
            //pulls data from the BillingInfo controller when creating a new payment method and assigns to the account
        }
        public static void getPaymentMethod(Account account) 
        {
            //pulls data from the account and shows the payment info
        }
    }
}
