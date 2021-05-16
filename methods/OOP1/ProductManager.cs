using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName+" added.");
        }
        public void Uptade(Product product)
        {
            Console.WriteLine(product.ProductName+" updated.");
        }

        public int Plus(int number1, int number2)
        {
            return number1 + number2;
        }
        public void Plus2(int number1, int number2)
        {
            Console.WriteLine(number1+number2);
        }
        //void geri döndürülemez değer üretir. Void metotlarda elde ettiğiniz sonucu kullanamazsın.
    }
}
