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
    public partial class CreateAccount : Form
    {
        private string username, password, repeatPassword;
        private StoreApp form;
        public CreateAccount(StoreApp f)
        {
            InitializeComponent();
            form = f;
        }

        public CreateAccount(StoreApp f, string _name, string _password, string _repeatPassword)
        {
            InitializeComponent();
            form = f;
            UsernameTextBox.Text = _name;
            PasswordTextBox.Text = _password;
            RepeatPasswordTextBox.Text = _repeatPassword;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            username = UsernameTextBox.Text;
            password = PasswordTextBox.Text;
            repeatPassword = RepeatPasswordTextBox.Text;

            //check if username is available
            if (Program.IsUsernameTaken(username))
            { 
                ShowError("Username is taken.");
            }

            //check if password matched the template
            else if (!Program.ValidatePassword(password))
            {
                ShowError("Password does not match the template.");
            }

            //check if passwords are the same
            else if (password != repeatPassword)
            {
                ShowError("Passwords do not match.");
            }

            if (Program.CreateAccount(username, password))
            {
                Form msg = new WelcomeMsg();
                form.HideLogInCreateAccountButtons();
                msg.Show();
                this.Close();
            }
            else { ShowError("Something went wrong...");}
        }
        private void ShowError(string msg)
        {
            Form error = new Error(msg);
            error.Show();
            Form newTry = new CreateAccount(form, username, password, repeatPassword);
            newTry.Show();
            this.Close();
        }
    }
}
