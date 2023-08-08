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

        internal static Account CurrentAccount { get => currentAccount; set => currentAccount = value; }
        internal static List<Account> Accounts { get => accounts; set => accounts = value; }


        public static bool isAdmin()
        {
            return currentAccount.IsAdmin;
        }

        public static void fill()
        {
            Accounts.Add(new Account("Admin", "Admin", "adm1234@pss.com", "iAmAdmin1", "Blue"));
            Accounts[0].IsAdmin = true;
            Accounts.Add(new Account("John", "Doe", "jfd1234@pss.com", "Password1", "Blue"));
            Accounts.Add(new Account("Alex", "Smith", "ads1234@pss.com", "Password2", "Red"));
            Accounts.Add(new Account("Jane", "Large", "jkl1234@pss.com", "Password3", "Green"));



        }

        public static bool login(String email, string password, string sq)
        {
            foreach (var account in Accounts)
            {
                if (account.Email == email)
                {
                    if (account.Password.Equals(password)) 
                    {
                        if (account.SecurityA.Equals(sq))
                        {
                            currentAccount = account;
                            return true;
                            
                        } else { return false; }
                    } else { return false; }
                }
            }
            return false;
        }

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
            Accounts.Add(account);
            CurrentAccount = account;

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
