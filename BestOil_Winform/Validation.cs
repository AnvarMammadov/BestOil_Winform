using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestOil_Winform
{
    public static  class Validation
    {
        public static bool CheckLiter(double liter)
        {
            
            if (liter <= 50000) return true;
            throw new ArgumentException("The maximum amount of liters you can purchase at once is 50 tons.");
        }
    }
}
