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
    public partial class LoginFail : Form
    {
        public LoginFail()
        {
            InitializeComponent();
        }

        private void OKLoginFailButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
