using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehtod_overloading
{
        class Program
        {
            // Method with no parameters that returns a default number
            public int Calculate()
            {
                return 10; // Default value
            }

            // Method with one parameter that squares the number
            public int Calculate(int number)
            {
                return number * number; // Return the square of the number
            }

            // Method with two parameters that multiplies the numbers
            public int Calculate(int number1, int number2)
            {
                return number1 * number2; // Multiply the two numbers
            }

            static void Main(string[] args)
            {
                Program program = new Program();

              
                Console.WriteLine("Default Calculation: " + program.Calculate());      
                Console.WriteLine("Square of 5: " + program.Calculate(5));                    
                Console.WriteLine("Multiplication of 4 and 6: " + program.Calculate(4, 6)); 

                Console.ReadLine();
            }
        }

}
