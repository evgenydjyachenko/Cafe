using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe.Forms
{
    public partial class SelectForm : Form
    {
        User user;

        AdminForm adminForm;

        CheckOutForm checkOutForm;

        ManagerForm managerForm;
        public SelectForm(User user)
        {
            InitializeComponent();
            this.user = user;

            switch(user.Role)
            {
                case UserRole.Admin:
                    checkOutButton.Enabled = false;
                    break;
                case UserRole.Manager:
                    adminFormButton.Enabled = false;
                    break;
                case UserRole.Teller:
                    adminFormButton.Enabled = false;
                    managerFormButton.Enabled = false;
                    break;
            }
        }
        private void openForm(Form form)
        {
            this.Visible = false;
            if (form.ShowDialog() == DialogResult.Cancel)
            {
                this.Visible = true;
            }
        }

        private void checkOutButton_Click(object sender, EventArgs e)
        {
            checkOutForm = new CheckOutForm();
            openForm(checkOutForm);

        }

        private void adminFormButton_Click(object sender, EventArgs e)
        {
            adminForm = new AdminForm(user);
            openForm(adminForm);
            
        }
    
        private void managerFormButton_Click(object sender, EventArgs e)
        {
            managerForm = new ManagerForm();
            openForm(managerForm);
        }
    }
}
