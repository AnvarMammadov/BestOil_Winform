using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestOil_Winform
{
    public static class CalculateFunctions
    {
        public static double CalculateFuelPriceByLiter(Fuel fuel,string liter)
        {
            if (liter == string.Empty) liter = "0";
            return Convert.ToDouble(liter) * fuel.Price;
        }

        public static double CalculateFuelLiterByAzn(Fuel fuel,string azn) {
            if (azn == string.Empty) azn = "0"; 
            return Convert.ToDouble(azn) / fuel.Price;
        }

        public static double CalculateFoodPrice(Food food,int count)
        {
            return food.Price * count;
        }
    }
}
