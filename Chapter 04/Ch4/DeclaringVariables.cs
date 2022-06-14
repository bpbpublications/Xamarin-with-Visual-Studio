using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4
{
    class DeclaringVariables
    {
        private void DeclaringVariablesDemo()
        {
            // Declares an Integer
            int anInteger = 2;
            // Declares a double and stores the result of a calculation
            double calculation = 74.6 * 834.1;
            // Declares one byte storing a hexadecimal value
            byte oneByte = 0x0;
            // Declares a string
            string sampleText = "Hello World in 2021!";
            // Declares a Boolean variable
            bool isTrueOrFalse = true;

            Console.WriteLine(anInteger);
            Console.WriteLine(calculation);
            Console.WriteLine(oneByte);
            Console.WriteLine(sampleText);
            Console.WriteLine(isTrueOrFalse);
            Console.ReadLine();

                
        }
    }
}
