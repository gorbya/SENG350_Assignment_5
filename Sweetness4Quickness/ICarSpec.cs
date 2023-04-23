using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweetness4Quickness
{
    public interface ICarSpec
        //This interface needs to be able to leverage all of the methods found in RacingCar.cs
    {
        public int GetMaxSpeed();
        public string GetFullCarName();
        public double GetCarFuelCap();

    }
}
