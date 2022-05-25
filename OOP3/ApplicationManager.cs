using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //method injection
     class ApplicationManager
    {
        public void MakeAnApplication(ICreditManager creditManager, ILoggerService loggerService)
        {
            //Başvuran bilgileri değerlendirme
            creditManager.Calculate();
            loggerService.Log();
            

        }

        public void KrediOnBilgilendirmesiYap(List<ICreditManager> krediler)
        {
            foreach (ICreditManager credit in krediler)
            {
                credit.Calculate();
            }
        }
    }
}
