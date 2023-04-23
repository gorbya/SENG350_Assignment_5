using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweetness4Quickness
{
    internal class Adapter : ICarSpec  
    {
        private RacingCar racingCar;

        public Adapter(RacingCar racingCar)
        {
            this.racingCar = racingCar;
        }
        public int GetMaxSpeed()
        { 
            return racingCar.GetTopSpeedRacingMode();
        }

        public string GetFullCarName()
        {
            // Combine the make, model, and year of the car into a single string
            return racingCar.GetMake() + " " + racingCar.GetModel() + " " + racingCar.GetYear();
        }

        public double GetCarFuelCap()
        {
            return racingCar.GetCarFuelCapacity();
        }
    }
}
