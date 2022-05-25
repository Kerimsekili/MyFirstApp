using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    internal class MorgageManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Morgage loan payment schedule has been calculated.");
        }

        public void DoingSomething()
        {
            throw new NotImplementedException();
        }
    }
}
