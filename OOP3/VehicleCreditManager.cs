using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    internal class VehicleCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Vehicle loan payment schedule has been calculated.");
        }

        public void DoingSomething()
        {
            throw new NotImplementedException();
        }
    }
}
