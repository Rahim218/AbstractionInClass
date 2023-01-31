using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    class Bicycle :Vehicle
    {
        public override void Drive(int km)
        {
            Milage += km;
        }
    }
}
