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
    public partial class GetDates : Form
    {
        public GetDates()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            DateTime from = FromDatePicker.Value;
            DateTime to = ToDatePicker.Value;
            Form showPurchases = new ShowPurchasesBetweenDates(from, to);
            showPurchases.Show();
            this.Close();
        }
    }
}
