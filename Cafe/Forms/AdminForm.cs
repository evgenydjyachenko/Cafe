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
    public partial class AdminForm : Form
    {
        DishData dishData;
        AddDishForm addDishForm;
        public AdminForm(User user)
        {
            InitializeComponent();
            dishData = new DishData();
            this.Text = user.FirstName + " " + user.LastName + " " + user.Role;
        }

        private void add_Button_Click(object sender, EventArgs e)
        {
            addDishForm = new AddDishForm();
            if (addDishForm.ShowDialog() == DialogResult.OK)
            {
                dishData.AddDish(addDishForm.NewDish);
                listBox1.Items.Add(addDishForm.NewDish);
            }
        }

        private void delete_Button_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) return;
            dishData.DeleteDish(listBox1.SelectedIndex);
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            dishData = (DishData)SerializeService.ObjDeserialize(typeof(DishData), dishData);

            foreach (Dish item in dishData.Dishes)
            {
                listBox1.Items.Add(item);
            }
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SerializeService.ObjSerialize(dishData, typeof(DishData));
        }
    }
}
