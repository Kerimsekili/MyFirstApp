using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class BasketManager
    {
        //naming convention
        public void Add(Product product)
        {
            Console.WriteLine("Tebrikler ,Sepete Eklendi : " + product.Name);
        }

        public void Add2(){}
    }
}
