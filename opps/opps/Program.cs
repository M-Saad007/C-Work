using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opps
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace ConsoleApp1
    {
        class Human
        {
            public string Name;
            public int Age;
            public string gender;
            public string country;

            public void Run()
            {
                Console.WriteLine($"{Name} is Running");
            }
            public void play()
            {
                Console.WriteLine($"{Name} is playing Cricket");
            }
        }

        class Student : Human
        {
            public string StudentID;

            public void Study()
            {
                Console.WriteLine($"{Name} is studying.");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Student detail = new Student();

                detail.Name = "Saad";
                detail.Age = 18;
                detail.gender = "Male";
                detail.country = "Pakistan";
                detail.StudentID = "S12345";

                detail.Run();
                detail.play();
                detail.Study();

                Console.WriteLine($"My name is {detail.Name} and I am {detail.Age} years old.\n" +
                                  $"I am {detail.gender} and I am living in {detail.country}.\n" +
                                  $"My Student ID is {detail.StudentID}.");

                Console.ReadKey();
            }
        }
    }
}
