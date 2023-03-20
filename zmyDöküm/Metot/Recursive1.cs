namespace _43LocalMetot
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            X();

            #region Recursive : Kendi içerisinde kendisini çağıran/tetikleyen fonksiyonlardı          
            void X(int a=1)
            {
                Console.WriteLine("Merhaba");
                if(a<3)
                {
                    X(++a);
                }
                
                Console.WriteLine("Dünya");
            }
            #endregion

            #region Örnek1  belirli değer aralığındaki 5'in katı olan tüm sayıları toplayan rec. fonksiyonu yazalım           
            Console.WriteLine(Kat(10,20));
            int Kat(int baslangic,int bitis)
            {
                if(baslangic % 5==0)
                {
                    return baslangic + Kat(++baslangic,bitis);           
                }
               if(baslangic<bitis)
                { 
                return Kat(++baslangic,bitis); // if kosulu saglanmıyorsa baslangici geri döndür en sondaki değeri geri döndür
                }
                return 0;

            }
            #endregion
        }
    }
}