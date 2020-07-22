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
    public partial class GetTotals : Form
    {
        public GetTotals()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            double from, to;
            
            from = double.Parse(FromTextBox.Text);
            to = double.Parse(ToTextBox.Text);

            if(from<0.0 || to<0.0) ShowError("Amount cannot be less than 0");

            Form showPurchases = new ShowPurchasesBetweenTotals(from, to);
            showPurchases.Show();
            this.Close();
        }

        private void ShowError(string msg)
        {
            Form error = new Error(msg);
            error.Show();
            Form newTry = new GetTotals();
            this.Close();
        }
    }
}
