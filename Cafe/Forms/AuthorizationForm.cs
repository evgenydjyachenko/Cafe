using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Cafe.Forms
{
    
    public partial class AuthorizationForm : Form
    {
        public static bool UserDataSerialize;

        UserData userData;

        RegistrationForm registrationForm;

        SelectForm selectForm;

        public AuthorizationForm()
        {
            InitializeComponent();
            userData = new UserData();
        }

        private void registration_LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registrationForm = new RegistrationForm(userData);
            registrationForm.ShowDialog();            
        }

        private void enter_Button_Click(object sender, EventArgs e)
        {
            User user = userData.Authorization(login_TextBox.Text, password_TextBox.Text);
            if(user == null)
            {
                MessageBox.Show("данные некорректны");
                return;
            }
            selectForm = new SelectForm(user);

            this.Visible = false;

            if (selectForm.ShowDialog() == DialogResult.Cancel)
            {
                this.Visible = true;
            }
        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {
            UserData temp = (UserData)SerializeService.ObjDeserialize(typeof(UserData),userData);
            if (temp != null)
            {
                userData = temp;
            }
        }

        private void AuthorizationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (UserDataSerialize == false)
            SerializeService.ObjSerialize(userData, userData.GetType());//typeof(UserData)
        }
    }
}
