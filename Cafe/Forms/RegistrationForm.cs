using Cafe.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe
{
    public partial class RegistrationForm : Form
    {
        private UserData userData;
        
        public RegistrationForm(UserData userData)
        {
            InitializeComponent();
            this.userData = userData;
            comboBox1.SelectedIndex = 0;
        }

        private void registration_Button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(login_TextBox.Text) || string.IsNullOrWhiteSpace(password_TextBox.Text)
                || string.IsNullOrWhiteSpace(firstName_TextBox.Text) || string.IsNullOrWhiteSpace(lastName_TextBox.Text)
                || string.IsNullOrWhiteSpace(email_TextBox.Text))
            {
                MessageBox.Show("Данные некорректны!");
                return;
            }

            userData.AllUsers.Add(new User(login_TextBox.Text, password_TextBox.Text, firstName_TextBox.Text, 
                lastName_TextBox.Text, email_TextBox.Text, (UserRole)comboBox1.SelectedIndex));

            this.DialogResult = DialogResult.OK;
        }
    }
}
