using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_v2
{
    public partial class StoreApp : Form
    {
        public StoreApp()
        {
            InitializeComponent();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            Form LogIn=new LogIn(this);
            LogIn.Show();
        }


        private void LogOutButton_Click(object sender, EventArgs e)
        {
            Program.LogOut();
            LogOutButton.Visible = false;
            LogInButton.Visible = true;
            CreateAccountButton.Visible = true;
            MakePurchaseButton.Visible = false;
            ShowBalanceButton.Visible = false;
            PayBalanceButton.Visible = false;
            ShowPurchasesBetweenDatesButton.Visible = false;
            ShowPurchasesInTotalRangeButton.Visible = false;
            ShowAllPurchasesButton.Visible = false;
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            Form CreateAccount=new CreateAccount(this);
            CreateAccount.Show();
        }

        public void HideLogInCreateAccountButtons()
        {
            LogInButton.Visible = false;
            CreateAccountButton.Visible = false;
            LogOutButton.Visible = true;
            MakePurchaseButton.Visible = true;
            ShowBalanceButton.Visible = true;
            PayBalanceButton.Visible = true;
            ShowPurchasesBetweenDatesButton.Visible = true;
            ShowPurchasesInTotalRangeButton.Visible = true;
            ShowAllPurchasesButton.Visible = true;
        }

        private void ShowItemsButton_Click(object sender, EventArgs e)
        {
            Form showItems = new ShowItems();
            showItems.Show();
        }

        private void MakePurchaseButton_Click(object sender, EventArgs e)
        {
            Form makePurchase = new MakePurchase();
            makePurchase.Show();
        }

        private void ShowBalanceButton_Click(object sender, EventArgs e)
        {
            Form showBalance = new ShowBalance();
            showBalance.Show();
        }

        private void PayBalanceButton_Click(object sender, EventArgs e)
        {
            Form payBalance = new PayBalance();
            payBalance.Show();
        }

        private void ShowAllPurchasesButton_Click(object sender, EventArgs e)
        {
            Form showPurchases = new ShowAllPurchases();
            showPurchases.Show();
        }

        private void ShowPurchasesBetweenDatesButton_Click(object sender, EventArgs e)
        {
            Form getDates = new GetDates();
            getDates.Show();
        }

        private void ShowPurchasesInTotalRangeButton_Click(object sender, EventArgs e)
        {
            Form getTotals = new GetTotals();
            getTotals.Show();
        }
    }
}


