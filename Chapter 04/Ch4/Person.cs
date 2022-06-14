using System;

namespace Ch4
{
    public static class HelperMethods
    {
        public static double
            CalculatePercentage(double inputValue, double percentage)
        {
            return inputValue / 100 * percentage;
        }
    }

    class Person
    {
        public DateTime BirthDate { get; set; }

        public Person(DateTime birthDate)
        {
            BirthDate = birthDate;
        }
        public Person()
        {
            BirthDate = new DateTime(1977, 05, 10);
        }

        public string FullName(string lastName, string firstName)
        {
            return string.Concat(lastName, " ", firstName);
        }

        public string FullName(string lastName, string firstName, int age)
        {
            return string.Concat(lastName, " ", firstName, " of age: ", age);
        }

        public string FullName(string lastName, string firstName, DateTime dateOfBirth)
        {
            return string.Concat(lastName, " ", firstName, " born on: ", dateOfBirth);
        }
    }

}
