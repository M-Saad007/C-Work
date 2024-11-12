using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps_Polymorphism
{
        class Vehicle
        {
            // Virtual method to simulate driving
            public virtual void Drive()
            {
                Console.WriteLine("The vehicle is driving.");
            }
        }

        // Derived class: Car
        class Car : Vehicle
        {
            public override void Drive()
            {
                Console.WriteLine("The car is driving on the road.");
            }
        }

        // Derived class: Truck
        class Truck : Vehicle
        {
            public override void Drive()
            {
                Console.WriteLine("The truck is driving with a heavy load.");
            }
        }

        // Derived class: Motorcycle
        class Motorcycle : Vehicle
        {
            public override void Drive()
            {
                Console.WriteLine("The motorcycle is speeding down the highway.");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                // Polymorphism: a single method behaves differently based on the object's type.
                Vehicle myVehicle = new Vehicle();
                Vehicle myCar = new Car();
                Vehicle myTruck = new Truck();
                Vehicle myMotorcycle = new Motorcycle();

                myVehicle.Drive();          // Output: The vehicle is driving.
                myCar.Drive();             // Output: The car is driving on the road.
                myTruck.Drive();           // Output: The truck is driving with a heavy load.
                myMotorcycle.Drive();      // Output: The motorcycle is speeding down the highway.

                Console.ReadLine();
            }
        }

}
