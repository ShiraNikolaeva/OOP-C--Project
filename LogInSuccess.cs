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
    public partial class LogInSuccess : Form
    {
        public LogInSuccess()
        {
            InitializeComponent();
        }

        private void LoginSuccessLabel_Click(object sender, EventArgs e)
        {

        }

        private void LoginSuccessOKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
