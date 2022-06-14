using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4.OOP
{
    class Inheritance
    {
        public class Customer : Person
        {
            public string CompanyName { get; set; }
        }


    }

    public interface IPerson
    {
        string LastName { get; set; }
        string FirstName { get; set; }
        DateTime DateOfBirth { get; set; }
        string FullName();
    }

    public class Person : IPerson
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public string FullName()
        {
            return $"{LastName} {FirstName}";
        }
    }

    public abstract class AbstractPerson
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public virtual string FullName()
        {
            return $"{LastName} {FirstName}";
        }
    }

    public class Customer : AbstractPerson
    {
        public int CustomerID { get; set; }
        public override string FullName()
        {
            return $"Customer ID: {CustomerID}, Last name: {LastName}";
        }
    }

}
