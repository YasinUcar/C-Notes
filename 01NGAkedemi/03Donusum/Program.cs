namespace _03Donusum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string yazi = "123";
            #region parse

            short x2 = short.Parse(yazi);
            Console.WriteLine(x2 * 5);
            #endregion

      
        #region ornek 2
        string medeniHal = "true";
        bool madeniMi = bool.Parse(medeniHal);
        Console.WriteLine(madeniMi);


            #endregion

            #region Convert Fonksiyonu
            string x = "25";
            Console.WriteLine(Convert.ToInt32(x));

            #endregion

            #region stringDonusum
            int a = 35;
            string yaz = Convert.ToString(a);
            Console.WriteLine(yaz);
            Console.WriteLine(yaz.GetType());
            #endregion

            Console.WriteLine();

            float f = 35;
            string gel = f.ToString();
            Console.WriteLine(gel);
            Console.WriteLine(gel.GetType());



            int d = 60000;
           byte y =(byte) d;
            
            Console.WriteLine(y);
        }
    }
}