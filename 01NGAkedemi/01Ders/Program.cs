using System;

namespace _01Ders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;
            object isim = "yasin";

            Console.WriteLine(isim);

            #region Boxing
            int yas = 28;
            object say1 = 28;

            #endregion
            #region casting unboxing
          int sayi=  (int)say1;
          Console.WriteLine(sayi * 5);
            #endregion
          
        }
    }
}