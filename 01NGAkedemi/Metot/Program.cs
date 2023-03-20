using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

namespace Metot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region başka metodu kullanmak
            Matematik mat = new Matematik();
            #endregion
            #region Opsiyonal Parametre Konusu 
            X(15);
            #endregion
          Console.WriteLine(mat.Carp(5, 5));

            #region non-trailing named argument sırasız değer verebilmek
            X(b: 15, a: 25);
            #endregion
        }
        static public void X(int a,int b=default) //default vermek lazım
        {
            Console.WriteLine(a+ b);
        
        }

    }
    class Matematik
    {
    public int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int Cikar(int sayi1,int sayi2)
        {
            return sayi1 - sayi2;
        }
        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
        public int Bol(int sayi1, int sayi2)
        {
            return sayi1 / sayi2;
        }
    }



}