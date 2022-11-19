using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe
{
    public class DishData: ISerialize
    {
        public List<Dish> Dishes { get; set; } = new List<Dish>();
        public string FileName { get; set; } = nameof(DishData); 
        

        public void AddDish(Dish dish)
        {
            Dishes.Add(dish);
        }

        public void DeleteDish(int index)
        {
            Dishes.RemoveAt(index);
        }

    }
}
