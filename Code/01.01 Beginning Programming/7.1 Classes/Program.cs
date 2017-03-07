using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person student1;
            student1 = new Person();
            student1
                .SetName("Orion", "Hall")
                .UpCaseName();
            
            Console.WriteLine("First name is: " +student1.GetFullName());

            Person student2 = MakeSomeoneNew();

            Console.WriteLine("Student 2's name is: " + student2.GetFullName());

            Console.ReadLine();
        }

        static Person MakeSomeoneNew()
        {
            Person newperson = new Person();
            newperson.SetName("John", "Blank");
            return newperson;
        }
    }

    class Person
    {
        private string FirstName;
        private string LastName;
        private string PreferredTitle;

        public Person SetName(string first, string last)
        {
            this.FirstName = first;
            this.LastName = last;
            this.PreferredTitle = "The Glorious";
            return this;
        }

        public Person UpCaseName()
        {
            FirstName = FirstName.ToUpper();
            LastName = LastName.ToUpper();
            return this;
        }

        public string GetFullName()
        {
            return (PreferredTitle + " " + FirstName + " " + LastName);
        }

    }


}
