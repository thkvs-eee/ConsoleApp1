using System;

namespace ValueAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 30;
            number1 = number2;
            number2 = 65;
            //number1=?

            int[] numbers1 = new int[] {10,20,30 };
            int[] numbers2 = new int[] { 100, 200, 300 };
            numbers1 = numbers2;
            numbers2[0] = 999;
            Console.WriteLine(numbers1[0]);
            //numbers[0]=?
            //int,decimal,float,double,bool = valuetype-----stack(memory)(değer tutan bellek)
            //array,class,interface = referencetype-----stack -> heap(memory)(adresleme yapan reference bellek)

        }
    }
}
