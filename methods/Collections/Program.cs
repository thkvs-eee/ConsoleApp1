using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            ////string[] names = new string[] { "engin", "murat", "kerem", "taha" };
            ////console.writeline(names[0]);
            ////console.writeline(names[1]);
            ////console.writeline(names[2]);
            ////console.writeline(names[3]);

            List<string> names2 = new List<string> { "Engin", "Murat", "Kerem", "Taha" };
            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            Console.WriteLine(names2[3]);
            names2.Add("İlker");
            Console.WriteLine(names2[4]);
            Console.WriteLine(names2[0]);
            

            //Arraylere sonradan ekleme yapılmaz, bu yüzden Listeler kullanırız.
        }
    }
}
