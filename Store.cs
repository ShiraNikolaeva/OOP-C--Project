using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Dynamic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;
using Project_v2;

namespace Project
{
    class Store
    {
        private readonly DataClassDataContext db;

        public Store(DataClassDataContext database)
        {
            this.db = database;
        }
        public bool CreateNewAccount(ref User_Account account, String username, String password)
        {
            //check if username is already used
            //validate password
            if (db.User_Accounts.Any(r => r.Username == username) && ValidatePassword(password))
            {
                //found a match, username is taken
                return false;
            }
            //create new Account
            User_Account newAccount = new User_Account
            {
                Username = username,
                User_Password = password,
                Balance = (decimal)0.0
            };
            account = newAccount;
            //insert row
            db.User_Accounts.InsertOnSubmit(newAccount);
            //submit changes to database
            db.SubmitChanges();
            return true;
        }

        public bool LogIn(string username, string password, ref User_Account account)
        {
            //pull up account by username. if not found return false and print no such account
            var findAccount = db.User_Accounts.Where(r => r.Username == username);
            if (!findAccount.Any()) return false;

            //confirm password. if not correct return false and print wrong password
            var confirmPassword = findAccount.Where(r => r.User_Password == password);
            if (!confirmPassword.Any()) return false;

                //username and password are correct, assign pointer of account to the account found
            account = confirmPassword.ToList()[0];
            return true;

        }

        public void LogOut(ref User_Account account)
        {
            account = null;
        }

        public List<Item> ShowItems()
        {
            try
            { 
                var availableItems = db.Items.Where(r => r.Qty_on_hand > 0).ToList();
                return availableItems;
            }
            catch (ArgumentNullException)
            {
                return null;
            }
        }

        public bool MakePurchase(ref User_Account account, int itemID, int qty)
        {
            //verify item is available to purchase in the qty 
            var isItemAvailable = db.Items.Where(r => r.ID == itemID && r.Qty_on_hand - qty > 0);
            if (!isItemAvailable.Any()) return false;

            Item item = isItemAvailable.ToList()[0];
            //verify user can make the purchase
            if (account.Balance - item.Price * qty < (decimal) -1000.0) return false;

            //create new Purchase
            Purchase purchase = new Purchase()
            {
                Account_ID = account.ID,
                Item_ID = item.ID,
                Qty=qty,
                Purchase_Date = DateTime.Now,
                Total = item.Price*qty
            };
            account.Purchases.Add(purchase);
            item.Qty_on_hand -= qty;
            decimal newBalance = account.Balance - item.Price * qty;
            account.Balance = newBalance;
            //insert row
            db.Purchases.InsertOnSubmit(purchase);
            //submit changes
            db.SubmitChanges();
            return true;
        }

        public void PayBalance( int ID, double amount)
        {
            if (amount < 0.0) return;

            var dbAccount = db.User_Accounts.Where(u => u.ID == ID);
            dbAccount.First().Balance += (decimal) amount;
            db.SubmitChanges();
        }

        public List<Purchase>  ShowAllPurchases(User_Account account)
        {
            try
            {
                var purchases = db.Purchases.Where(r => r.Account_ID == account.ID).ToList();
                return purchases;
            }
            catch (ArgumentNullException)
            {
                return null;
            }
        }

        public List<Purchase> ShowPurchasesWithinDates(User_Account account, DateTime start, DateTime end)
        {
            try
            {
                var purchases = db.Purchases.Where(r=>r.Account_ID==account.ID)
                    .Where(r => r.Purchase_Date <= end && r.Purchase_Date >= start).ToList();
                return purchases;
            }
            catch (ArgumentNullException)
            {
                return null;
            }
        }

        public List<Purchase> ShowPurchasesWithinTotals(User_Account account, double start, double end)
        {
            try
            {
                var purchases = db.Purchases.Where(r => 
                    r.Account_ID == account.ID && r.Total >= (decimal) start && r.Total <= (decimal) end).ToList();
                return purchases;
            }
            catch (ArgumentNullException)
            {
                return null;
            }
        }

        public bool IsUsernameTaken(String target)
        {
            var answer = db.User_Accounts.Any(n => n.Username == target);
            return answer;
        }

        public Item FindItem(int ID)
        {
            var item = db.Items.Where(i => i.ID == ID);
            return item.First();
        }


        private bool ValidatePassword(string password)
        {
            //password has to contain at least 1 upper and 1 lower case letters, 1 digit and 1 special character
            //has to be at least 8 characters and no more than 40
            Regex regex = new Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[^\\da-zA-Z]).{8,40}$");
            return regex.IsMatch(password);
        }
    }
}
