using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    internal class PersonalFinanceCreditManager :ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Personal finance loan payment schedule has been calculated.");
        }

        public void DoingSomething()
        {
            throw new NotImplementedException();
        }
    }
}
