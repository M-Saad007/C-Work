using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstwork
{
    class Program
    {
        static void Main(string[] args)
        {
           
                Console.WriteLine("Enter your Name");

                string username = Console.ReadLine();

             Console.WriteLine("Enter your Password");

             string password = Console.ReadLine();


              if (username == "Saad" && password == "abc123" || username == "Usama" && password == "abcd1234")
              {
                  Console.WriteLine("login");
                Console.WriteLine("Welcome "+ username);
            }
              else
              {
                  Console.WriteLine("wrong crediantial");
              }
           
            Console.ReadKey();
        }
    }
}
