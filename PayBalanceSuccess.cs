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
    public partial class PayBalanceSuccess : Form
    {
        public PayBalanceSuccess(double balance)
        {
            InitializeComponent();
            BalanceLabel.Text = balance.ToString();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
