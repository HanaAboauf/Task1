using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{

    //12.	Create a struct called "Person" with properties "Name" and "Age".
    //Write a C# program that takes details of 3 persons as input from the user [Name Can not be Null Or Empty and Age in range 20 - 50]
    //and displays the name and age of the oldest person. 
    internal struct Person
    {

        #region Attributes

        private string name;
        private int age;
        #endregion

        #region Properties
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("You must enter valid input"); 
                }
                name = value;
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 20 || value > 50)
                {
                    Console.WriteLine("You must enter valid input");
                }
                age = value;
            }
        }

        #endregion

        #region Methods

        public static void GetOldestPerson(Person a, Person b, Person c) {

            if (a.Age >= b.Age && a.Age >= c.Age)
            {
                Console.WriteLine($"The oldest person is {a.Name} with age {a.Age}");
            }
            else if (b.Age >= a.Age && b.Age >= c.Age)
            {
                Console.WriteLine($"The oldest person is {b.Name} with age {b.Age}");
            }
            else
            {
                Console.WriteLine($"The oldest person is {c.Name} with age {c.Age}");
            }
        }
        #endregion
    }
}
