namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Constructor : İnşa edici metotlara denmektedir
            MyClass m1 = new MyClass(5);
         
            
        }
    }
    class MyClass
    {
        //Constructor olabilmesi için ismi aynı olan public bir değişken tanımlanır void vs. dönmesine gerek yoktur
        public MyClass()
        {
            Console.WriteLine("Default olarak böyle çalışırım");
        }
        //burada this koymak zorunda değildi eğer bu işlemden sonra this koyulursa overload yapımış metotlara erişim sağlanabilir biz burada varsayılan constructra eriştirk böylece sayı verdiğimizde hem bu metot hem default metot tetiklenecktir
        public MyClass(int a) : this() //değer almak zorunda değildir overload edilebilir
        {
            Console.WriteLine("Merhaba Dünya"+ a);
        }
        public int Sayi1 { get; set; }
        public int Sayi2 { get; set; }
    }
}

#endregion