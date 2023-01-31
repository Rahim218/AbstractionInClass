using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Car : Vehicle
    {
        public double CurrentFuel;
        public double FuelFor1km;
        public override void Drive(int km)
        {
            double needFuel = FuelFor1km * km;
            if (CurrentFuel>needFuel)
            {
                CurrentFuel-=needFuel;
                Milage+=km;
            }
        }
    }
}
