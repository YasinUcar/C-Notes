namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Destructor(Yıkıcı) Metot nesne imha edilirken otamatik olarak çağırılan metottur final metot    
            X();
            GC.Collect();//garbage collectore eriştik ve gereksiz şeyleri silmesini söyledik böyle yapmadığımızda class'da decons çok uzun sürelerde çalışı ve çalışsa dahi biz main bittiği görevini yaptığı
                         //için bunu console'da göremeyiz sadece ram'e etki eder
            #endregion
        }
        static void X()
        {
            MyClass m = new MyClass();
        }
        class MyClass
        {
            public MyClass() //constructor başladığında oluşur
            {
                Console.WriteLine("Selamin aleyküm");
                
            }
            ~MyClass()//program sonlanırken çalışır devreye girmesi için null olması garbage collector'ın otamatik devreye girmesi gerekir
            {
                Console.WriteLine("Hadi selametle ben işimi bitirdim hacii");
            }
        }
    
    }
    
}