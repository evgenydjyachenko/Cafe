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
    public partial class AddDishForm : Form
    {
        Dish newDish;

        public Dish NewDish { get { return newDish; } }   
        public AddDishForm()
        {
            InitializeComponent();
        }

        private void addDishButton_Click(object sender, EventArgs e)
        {
            try
            {
                newDish = new Dish(dishNameTextBox.Text, (double)dishPriceNumericUpDown1.Value, (double)dishCookingTimeNumericUpDown2.Value);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                this.DialogResult = DialogResult.Cancel;
                MessageBox.Show(ex.Message);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
