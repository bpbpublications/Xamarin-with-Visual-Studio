using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4
{
    class Loops
    {
        private void DoLoop()
        {
            int max = 0;
            do
            {
                Console.WriteLine(max);
                max++;
            } while (max < 10);

        }

        private void WhileLoop()
        {
            int max = 0;
            while (max < 10)
            {
                Console.WriteLine(max);
                max++;
            }

        }
    }
}
