using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4.Advanced
{
    class AdvancedProgramming
    {
        private void Generics()
        {
            var integerList = new List<int>();
            integerList.Add(1);
            integerList.Add(2);
            Console.WriteLine(integerList[1]); // writes 2
            integerList.Remove(1); // removes 1

            //int first = 0;
            //int second = 1;
            //var integerList = new List<int> { first, second };

        }

        private void NullableTypes()
        {
            //Nullable<int> oneInteger = 0;
            int? oneInteger = 0;
            if (oneInteger.HasValue)
                Console.WriteLine(oneInteger.Value);

        }

        private void LINQQuery()
        {
            var people = new List<Person>();

            people.Add(new Person { DateOfBirth = new DateTime(1977, 05, 10), FirstName = "Alessandro", LastName = "Del Sole" });
            people.Add(new Person { DateOfBirth = new DateTime(1974, 06, 2), FirstName = "Robert", LastName = "White" });

            var query = from person in people
                        where person.DateOfBirth.Year < 2000
                        select person;

            var lambdaQuery = people.Where(person => person.BirthDate.Year < 2000).First();
        }

        private async Task<bool> ReadFileAsync(string fileName)
        {
            try
            {
                string fileContent = await File.ReadAllTextAsync(fileName);

                Console.WriteLine(fileContent);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
