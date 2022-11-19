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
    public partial class ManagerForm : Form
    {
        UserData userData;
        User user;
        int index;
        public ManagerForm()
        {
            InitializeComponent();
            userData = new UserData();
            
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            userData = (UserData)SerializeService.ObjDeserialize(typeof(UserData), userData);

            foreach (User item in userData.AllUsers)
            {
                if (item.Role == UserRole.Teller)
                {
                    tellerListBox.Items.Add(item);

                }
            }
        }

        private void tellerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tellerListBox.SelectedItem == null)
                return;

            string[] results = tellerListBox.SelectedItem.ToString().Split(':', ' ');//split разбивает строки на подстроки

            user = userData.GetUser(results[3]);

            tellerInfoLabel.Text = user.ToString();
            rateNumericUpDown1.Value = user.Rate;
        }

        private void rateButton_Click(object sender, EventArgs e)
        {
            index = tellerListBox.SelectedIndex;
            user.Rate = (int)rateNumericUpDown1.Value;
            tellerListBox.Items[index] = user;
            userData.SaveUser(user);
        }

        private void ManagerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SerializeService.ObjSerialize(userData, typeof(UserData));
            AuthorizationForm.UserDataSerialize = true;
        }
    }
}
