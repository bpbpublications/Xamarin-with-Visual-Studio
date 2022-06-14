using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4
{
    class ConditionalCodeBlocks
    {
        private void IfDemo()
        {
            Console.WriteLine("Enter a valid string (min 5 characters, max 10");
            string inputString = Console.ReadLine();

            if (inputString.Length < 5)
            {
                Console.WriteLine("The input string is too short");
            }
            else if (inputString.Length > 10)
            {
                Console.WriteLine("The input string is too long");
            }
            else
            {
                Console.WriteLine("The input string is valid");
            }

        }

        private void SwitchDemo()
        {
            Console.WriteLine("Enter a valid string (min 5 characters, max 10");
            string inputString = Console.ReadLine();
            switch (inputString.Length)
            {
                case < 5:
                    Console.WriteLine("The input string is too short");
                    break;
                case > 10:
                    Console.WriteLine("The input string is too long");
                    break;
                default:
                    Console.WriteLine("The input string is valid");
                    break;
            }

        }
    }
}
