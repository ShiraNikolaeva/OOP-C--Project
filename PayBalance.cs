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
    public partial class PayBalance : Form
    {
        public PayBalance()
        {
            InitializeComponent();
            BalanceLabel.Text = Program.GetBalance().ToString();
        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            double amount = double.Parse(AmountTextBox.Text);
            if (amount < 0)
            {
                Form error=new Error("You cannot pay a negative amount");
                error.Show();
                Form newTry=new PayBalance();
                newTry.Show();
                this.Close();
            }

            double newBalance = Program.PayBalance(amount);
            Form payBalanceSuccess = new PayBalanceSuccess(newBalance);
            payBalanceSuccess.Show();
            this.Close();
        }
    }
}
