using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweetness4Quickness
{ 
    class Driver
        //This is really the 'tester class' from part 3, I just thought calling it 'Driver' was kinda fun
    {
        static void Main(string[] args)
        {
            // create a RacingCar instance (This is the 'third-party')
            RacingCar racingCar = new RacingCar(180, 90, "Honda", "CR-V", "2012", 15);

            // create an adapter instance (This is an instance of our custom adapter that uses our awesome interface) 
            ICarSpec adapter = new Adapter(racingCar);

            // use the adapter to get the car specs
            Console.WriteLine("Car Name: " + adapter.GetFullCarName());
            Console.WriteLine("Max Speed: " + adapter.GetMaxSpeed() + " mph");
            Console.WriteLine("Fuel Capacity: " + adapter.GetCarFuelCap() + " gallons \n");

            //Now I just want to do more because it's fun lol

            // create a RacingCar instance (This is the 'third-party')
            RacingCar racingCar2 = new RacingCar(45, 10, "Pontiac", "Aztek", "2008", 13);

            // create an adapter instance (This is an instance of our custom adapter that uses our awesome interface) 
            ICarSpec adapter2 = new Adapter(racingCar2);

            // use the adapter to get the car specs
            Console.WriteLine("Car Name: " + adapter2.GetFullCarName());
            Console.WriteLine("Max Speed: " + adapter2.GetMaxSpeed() + " mph");
            Console.WriteLine("Fuel Capacity: " + adapter2.GetCarFuelCap() + " gallons");

        }
    }
}
