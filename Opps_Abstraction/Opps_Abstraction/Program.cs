using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps_Abstraction
{
        public abstract class Appliance
        {
            
            public abstract void TurnOn();
            public abstract void TurnOff();
        }

        
        public class Fan : Appliance
        {
            public override void TurnOn()
            {
                Console.WriteLine("Fan is now ON.");
            }

            public override void TurnOff()
            {
                Console.WriteLine("Fan is now OFF.");
            }
        }

   
        public class AirConditioner : Appliance
        {
            public override void TurnOn()
            {
                Console.WriteLine("Air Conditioner is now ON.");
            }

            public override void TurnOff()
            {
                Console.WriteLine("Air Conditioner is now OFF.");
            }
        }

        class Program
        {
            static void Main()
            {
             
                Appliance myFan = new Fan();
                myFan.TurnOn(); 
                myFan.TurnOff(); 

                Appliance myAC = new AirConditioner();
                myAC.TurnOn();  
                myAC.TurnOff();  

                Console.ReadKey();
            }
        }

}
