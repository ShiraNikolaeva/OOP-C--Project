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
    public partial class ShowBalance : Form
    {
        public ShowBalance()
        {
            InitializeComponent();
            BalanceLabel.Text = Program.GetBalance().ToString();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
