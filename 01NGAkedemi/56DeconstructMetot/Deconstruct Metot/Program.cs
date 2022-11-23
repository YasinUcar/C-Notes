namespace Deconstruct_Metot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region dışarıya değer almak istediğimizde bunu hızlı bir şekilde yapmamızı sağlar bunun için başka yöntemlerde mevcuttur

            MyClass my = new MyClass
            {
                Adi = "Yasin",
                Yas = 24,
            };
            //dışarıya turple operatörü ile bu değerleri hızlıca alalım
            var (x,y) = my;
            Console.WriteLine(x);

        }
    }
    class MyClass
    {
        public int Yas{ get; set; }
        public int Yas2{ get; set; }
        public string Adi{ get; set; }

        //bunun içingerekli olan metot isminin Deconstruct olması lazım
        public void Deconstruct (out string Adi,out int Yas) 
        {
            Adi = this.Adi;
            Yas = this.Yas;
        }

    }
    #endregion
}