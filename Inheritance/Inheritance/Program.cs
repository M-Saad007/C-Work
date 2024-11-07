using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Human
    {
        public string Name;
        public int Age;
        public string Gender;
        public string Country;

        public void travel()
        {
            Console.WriteLine($"{Name} is Travelling");
        }

        public void Play()
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

    class GraduateStudent : Student
    {
        public string Degree;
        public string University;

        public void Graduate()
        {
            Console.WriteLine($"{Name} has graduated with a {Degree} from {University}.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            GraduateStudent detail = new GraduateStudent();

            detail.Name = "Saad";
            detail.Age = 22;
            detail.Gender = "Male";
            detail.Country = "Pakistan";
            detail.StudentID = "S12345";
            detail.Degree = "Bachelor of Computer Science";
            detail.University = "XYZ University";

            detail.travel();       
            detail.Play();       
            detail.Study();       
            detail.Graduate();    

            Console.WriteLine($"My name is {detail.Name} and I am {detail.Age} years old.\n" +
                              $"I am {detail.Gender} and I am living in {detail.Country}.\n" +
                              $"My Student ID is {detail.StudentID}.\n" +
                              $"I graduated with a {detail.Degree} from {detail.University}.");

            Console.ReadKey();
        }
    }
}

