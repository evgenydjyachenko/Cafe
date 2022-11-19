using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe
{
    public class Dish
    {
        //TODO: Добавить Image
        public string Name { get; set; }
        public double Price { get; set; }
        public double CookingTime { get; set; }
        public Dish()
        {

        }
        public Dish(string name, double price, double cookingTime)
        {
            Name = name;
            Price = price;
            CookingTime = cookingTime;
        }

        public override string ToString()
        {
            return $"Название: {Name} Цена: {Price}, Время приготовления: {CookingTime}";
        }
    }
}
