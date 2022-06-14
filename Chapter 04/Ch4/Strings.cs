using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4
{
    class Strings
    {
        string hello = "Hello World!";
        string hello2 = "Hello World";

        private void Comparison()
        {
            bool areStringEqual = hello == hello2; // false
            bool areStringDifferent = hello != hello2; // true
        }

        private void Concatenation()
        {
            string result = string.Concat(hello2, hello);
            string interpolation = $"{hello2} {hello}";

            // Requires a using System.Text directive
            string first = "first";
            string second = "second";
            string third = "third";
            StringBuilder builder = new StringBuilder();
            builder.Append(first);
            builder.AppendLine(second);
            builder.AppendLine(third);
            string finalResult = builder.ToString();
        }

        private void Formatting()
        {
            // Returns "The cost of fuel is $1.00
            Console.WriteLine(string.Format(@"The cost of fuel is {0:C} dollars", 1));
            // Returns "You are eligible for a 21.50% discount"
            Console.WriteLine(string.Format("You are eligible for a {0:P} discount", 21.5F));
            // Returns "Hex counterpart for 10 is A"
            Console.WriteLine(string.Format("Hex counterpart for 10 is {0:X}", 10));

        }

    }
}
