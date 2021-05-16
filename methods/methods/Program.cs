using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "Apple";
            product1.Price = 15;
            product1.Description = "Amasya's Apple";
            product1.StockPiece = 20;

            Product product2 = new Product();
            product2.Name = "Watermeloon";
            product2.Price = 80;
            product2.Description = "Diyarbakır's Watermeloon";
            product2.StockPiece = 11;

            Product[] products = new Product[] {product1,product2 };

           
            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Description);
                Console.WriteLine(product.StockPiece);
                Console.WriteLine("--------------");
            }
            Console.WriteLine("-----------Methods---------");
            // instance- örnek
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);     
        }
    }
}

// Tekrar tekrar kullanılabilirliği sağlayan yapılara metot denir. Don't Repeat Yourself(DRY)-Clean Code-Best Practice
