using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Sweetness4Quickness
{
    internal class RacingCar
        //This is the 'third party' code
    {
        private int topSpeedRacingMode;
        private int topSpeedNormalMode;
        private string make;
        private string model;
        private string year;
        private double carFuelCapacity;

        public RacingCar(int topSpeedRacingMode, int topSpeedNormalMode, string make, string model, string year, double carFuelCapacity)
        {
            this.topSpeedRacingMode = topSpeedRacingMode;
            this.topSpeedNormalMode = topSpeedNormalMode;
            this.make = make;
            this.model = model;
            this.year = year;
            this.carFuelCapacity = carFuelCapacity;
        }


        public int GetTopSpeedRacingMode()
        {
            return topSpeedRacingMode;
        }

        public int GetTopSpeedNormalMode()
        {
            return topSpeedNormalMode;
        }

        public string GetMake()
        {
            return make;
        }

        public string GetModel()
        {
            return model;
        }

        public string GetYear()
        {
            return year;
        }

        public double GetCarFuelCapacity()
        {
            return carFuelCapacity;
        }
    }
}
