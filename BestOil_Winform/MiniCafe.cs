using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestOil_Winform
{
    public class MiniCafe
    {
        public List<Food> Foods { get; set; } = new List<Food>();
        
        public double GetFoodPrice(string foodName)
        {
            foreach (Food food in Foods)
            {
                if (foodName == food.Name) return food.Price;
            }
            return 0;
        }

        public Food GetFood(string foodName)
        {
            foreach(Food food in Foods)
            {
                if(foodName == food.Name) { return food; }
            }return null;   
        }
    }
}
