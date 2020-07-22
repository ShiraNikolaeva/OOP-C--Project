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
    public partial class LogIn : Form
    {
        private StoreApp form;
        public LogIn(StoreApp f)
        {
            InitializeComponent();
            form = f;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            String username = UsernameTextBox.Text;
            String password = PasswordTextBox.Text;
            Form msg;
            if (Program.LogIn(username, password))
            {
                msg = new LogInSuccess();
                msg.Show();
                form.HideLogInCreateAccountButtons();
            }
            else
            {
                msg = new LoginFail();
                msg.Show();
            }
            this.Close();
        }
    }
}
