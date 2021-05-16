using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryID = 2;
            product1.ProductName = "Table";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id = 2, CategoryID = 5, UnitsInStock = 5,
                ProductName = "Pencil", UnitPrice = 35 };
            //PascalCase   //camelCase
            ProductManager productManager = new ProductManager();
            productManager.Uptade(product1);
            productManager.Add(product2);
            
            productManager.Plus2(3, 6);
            int resultPlus = productManager.Plus(3, 6);
            Console.WriteLine(resultPlus*2);









        }
    }
}
