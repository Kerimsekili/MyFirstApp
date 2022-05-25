using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
           ICreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
           ICreditManager vehicleCreditManager = new VehicleCreditManager();
           ICreditManager morgageManager = new MorgageManager();

           
           ILoggerService databaseLoggerService = new DatabaseLoggerService();
           ILoggerService fileLoggerService = new FileLoggerService();

            ApplicationManager applicationManager = new ApplicationManager();
           applicationManager.MakeAnApplication(morgageManager,databaseLoggerService);

           List<ICreditManager> krediler = new List<ICreditManager>{personalFinanceCreditManager,morgageManager};

           //applicationManager.KrediOnBilgilendirmesiYap(krediler);


        }
    }
}
