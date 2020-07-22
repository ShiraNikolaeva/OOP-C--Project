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
    public partial class Receipt : Form
    {
        public Receipt( DateTime date, string item, double price, int qty, double total)
        {
            InitializeComponent();
            DateLabel.Text = date.ToString();
            ItemDescLabel.Text = item;
            PricePerItemLabel.Text = price.ToString();
            QtyLabel.Text = qty.ToString();
            TotalLabel.Text = total.ToString();
            NameLabel.Text = Program.GetUsername();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
