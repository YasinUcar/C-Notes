namespace _02Var
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var isim = "Yasin";
            var madeniHal = true;

            #region dynamic
            dynamic yazi= "Yasin";
            Console.WriteLine(yazi.GetType());
            //dynamic bir değişkenin formatini sonradan değiştirebiliriz
            //türünü bilmediğin değişkenler için kullanılabilir
            yazi = 15;
            Console.WriteLine(yazi.GetType());
            #endregion
        }
    }
}