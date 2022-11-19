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
    public partial class CheckOutForm : Form
    {
        private DishData dishData;

        private List <Customer> customers;

        private Dictionary<int, double> orderqueue;

        private List<Customer> waitOrderCustomers;

        public static double time;
        public CheckOutForm()
        {
            InitializeComponent();
            dishData = new DishData();
            //customerTimer.Interval = 10000; установка интервала времени для таймера
            customerTimer.Start();
            customers = new List<Customer>();
            orderqueue = new Dictionary<int, double>();
            waitOrderCustomers = new List<Customer>();

        }

        private void CheckOutForm_Load(object sender, EventArgs e)
        {
            dishData = (DishData)SerializeService.ObjDeserialize(typeof(DishData), dishData);
        }

        private void customerTimer_Tick(object sender, EventArgs e)
        {
            if (customerQueueListBox.Items.Count > 15)
            {
                customerTimer.Stop();
                return;
            }
            //.Text = customerTimer.ToString();
            customers.Add(new Customer(dishData));
            customerQueueListBox.Items.Add(customers.Last());

        }

        private void acceptOrderButton_Click(object sender, EventArgs e)
        {
            int index = customerQueueListBox.SelectedIndex;
            
            double time = customers[index].Order[0].CookingTime + customers[index].Order[1].CookingTime;
            customers[index].NumberOrder = customers[index].Id;
            waitOrderCustomers.Add(customers[index]);
            
            orderqueue.Add(customers[index].NumberOrder, time);

            orderQueueListBox.Items.Add(customers[index]);
            waitOrderQueueLabel.Text += customers[index] + Environment.NewLine;
            customerQueueListBox.Items.RemoveAt(index);
            customers.RemoveAt(index);
            cookingTimer.Start();

            //customerQueueListBox.Items.Add(new Customer(dishData));
        }

        private void customerQueueListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (customerQueueListBox.SelectedIndex == -1)
                return;
            customerOrderQueueLabel.Text = customers[customerQueueListBox.SelectedIndex].OrderText();
        }

        private void customerOrderQueueLabel_Click(object sender, EventArgs e)
        {

        }

        private void cookingTimer_Tick(object sender, EventArgs e)
        {
            time+=1;
            int readyFood = 0;
            int counter = 0;

            if (orderqueue.ContainsValue(time) == true)
            {
                foreach (var item in orderqueue)
                {
                    counter++;
                    if (item.Value == time)
                    {
                        time = 0;
                        readyFood = item.Key;
                        readyOrderLabel.Text += item.Key + " Заказ готов." + Environment.NewLine;
                        
                        uprateWaitOrder(readyFood);
                        break;
                    }
                }

                orderqueue.Remove(readyFood);

                orderQueueListBox.Items.RemoveAt(counter-1);
            }

        }

        private void uprateWaitOrder(int numberOrder)
        {
            for (int i = 0; i < waitOrderCustomers.Count; i++)
            {
                if (waitOrderCustomers[i].NumberOrder == numberOrder)
                {
                    waitOrderCustomers.RemoveAt(i);
                    break;
                }
            }
            waitOrderQueueLabel.Text = "";
            foreach(Customer item in waitOrderCustomers)
            {
                if (item.NumberOrder > 0)
                {
                    waitOrderQueueLabel.Text += item + Environment.NewLine;
                }
            }
        }
    }
}
