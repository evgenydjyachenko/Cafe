using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Forms
{
    public class Customer
    {
        private DishData dishData;
        
        public static int Counter;
        public int Id { get; set; }

        public int NumberOrder { get; set; }

        public List <Dish> Order { get; set; } = new List<Dish>();  

        public Customer(DishData dishData)
        {
            Counter++;
            Id = Counter;
            this.dishData = dishData;
            createOrder();
        }

        private void createOrder()
        {
            //todo - добавить проверку
            Random rand = new Random();
            int index1 = rand.Next(0, dishData.Dishes.Count);
            int index2 = rand.Next(0, dishData.Dishes.Count);

            Order.Add(dishData.Dishes[index1]);
            Order.Add(dishData.Dishes[index2]);

        }

        public override string ToString()
        {
            return $"\n Номер заказа: {Id}";
        }

        public string OrderText()
        {
            string res = "";
            foreach(Dish dish in Order)
            {
                res += dish.Name + " " + dish.Price + Environment.NewLine;
            }
            return res;
        }

    }
}
