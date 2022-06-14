using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4.OOP
{
    public enum Food
    {
        Bread,      // 0
        Tomato,     // 1
        Potato,     // 2
        Chicken,    // 3
        Fish        // 4
    }

    class Enumerations
    {
        private void CheckFood(Food foodList)
        {
            switch (foodList)
            {
                case Food.Bread:
                    {
                        Console.WriteLine("You chose Bread");
                        break;
                    }

                case Food.Chicken:
                    {
                        Console.WriteLine("You chose Chicken");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("All food is good");
                        break;
                    }
            }
        }

    }
}
