namespace StaticConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Static Constructor bir İLK defa sınıftan nesne üretilirken ilk tetiklenen metottur daha sonrada normal constructır  tetiklenir 
            MyClass m1 = new();
            #endregion
        }
    }
    //normal const her nesne üretilirken bir kere tetiklenmektedi
    //static const ise ilk defa nesne üretiliyorsea ilgili nesne üretilirken tetiklenen fonksiyondur
    class MyClass  
    {
        static MyClass() //parametre almaz 
        {
            Console.WriteLine("İlk tetiklenen");
        }
        public MyClass()
        {
            Console.WriteLine("Bende çalıştım ama ikinci");
        }
    }
}