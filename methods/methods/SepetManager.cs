using System;
using System.Collections.Generic;
using System.Text;

namespace methods
{
    class SepetManager
    {
        // naming convention
        //syntax - yazım şekli
        public void Add(Product product)
        {
            Console.WriteLine("Congratulations, Added basket: "+ product.Name);
            Console.WriteLine("Stock Piece: " + product.StockPiece);
        }
        
    }
}
