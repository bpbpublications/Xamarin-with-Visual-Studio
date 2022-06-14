using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4
{
    class Operators
    {
        private void EqualityOperators()
        {
            bool trueValue = true;
            if (trueValue == true)
            {
                // Condition is true
            }
            if (trueValue != true)
            {
                // Condition is false
            }

        }

        private void DirectTypeConversion()
        {
            var onePerson = new Person();
            object aPerson = onePerson;

            Person result = (Person)aPerson;    // if it fails, exception thrown
            Person result2 = aPerson as Person; // if it fails, null is assigned
            if (result2 != null)
            {
                // Do something
            }
        }

        private void TypeConversion()
        {
            double value = 2.5;
            decimal result = Convert.ToDecimal(value);
        }

        private void LogicalOperators()
        {
            DateTime firstDate = new DateTime(2021, 10, 25);
            DateTime secondDate = new DateTime(2021, 11, 30);
            if (firstDate > DateTime.Today && firstDate < secondDate)
            {
                // if firstDate is greater than today AND less than secondDate....
            }

            if (firstDate > DateTime.Today || firstDate < secondDate)
            {
                // if firstDate is greater than today OR less than secondDate....
            }

        }
    }
}
