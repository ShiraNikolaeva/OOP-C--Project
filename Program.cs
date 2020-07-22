using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project;

namespace Project_v2
{
    static class Program
    {
        private static Store store;
        private static User_Account currentAccount = new User_Account();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread] 
        static void Main()
        {
            
            using (DataClassDataContext database = new DataClassDataContext())
            {
                currentAccount.ID = 0;
                currentAccount.User_Password = "0";
                currentAccount.Username = "0";
                currentAccount.Balance = (decimal)0.0;
                store =new Store(database);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new StoreApp());
            }
        }

        public static bool LogIn(String username, String password)
        {
            return store.LogIn(username, password, ref currentAccount);
        }

        public static void LogOut()
        { 
            store.LogOut(ref currentAccount);
        }

        public static bool CreateAccount(String username, String password)
        {
            return store.CreateNewAccount(ref currentAccount, username, password);
        }

        public static bool ValidatePassword(String password)
        {
            //password has to contain at least 1 upper and 1 lower case letters, 1 digit and 1 special character
            //has to be at least 8 characters and no more than 40
            Regex regex = new Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[^\\da-zA-Z]).{8,40}$");
            return regex.IsMatch(password);
        }

        public static bool IsUsernameTaken(String target)
        {
            return store.IsUsernameTaken(target);
        }

        public static List<Item> ShowItems()
        {
            return store.ShowItems();
        }

        public static bool MakePurchase(int itemID, int qty)
        {
            return store.MakePurchase(ref currentAccount, itemID, qty);
        }

        public static Item FindItem(int ID)
        {
            return store.FindItem(ID);
        }

        public static double GetBalance()
        {
            return (double) currentAccount.Balance;
        }

        public static string GetUsername()
        {
            return currentAccount.Username;
        }

        public static double PayBalance(double amount)
        {
            store.PayBalance(currentAccount.ID, amount);
            return (double) currentAccount.Balance;
        }

        public static List<Purchase> ShowAllPurchases()
        {
            return store.ShowAllPurchases(currentAccount);
        }

        public static List<Purchase> ShowPurchasesBetweenDates(DateTime from, DateTime to)
        {
            return store.ShowPurchasesWithinDates(currentAccount, from, to);
        }

        public static List<Purchase> ShowPurchasesWithinTotals(double from, double to)
        {
            return store.ShowPurchasesWithinTotals(currentAccount, from, to);
        }
    }
}
