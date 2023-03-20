namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Records ile objede mevcut olan bütün değerleri init yapmak yani başlangıç değeri verip daha sonrak kullanılmasını istiyorsak
            //tek tek bütün propları init yapmaktansa records objesini nesnesini kulanıyoruz
            //alayı readonly ise record kullan nesnenin readonly olması metotlar proplar vs.
            MyRecord myRecord = new MyRecord()
            {
                Name = "Yasin",
                Yasi = 24,
            };
    #endregion
           #region //With Expressions  readonly olarak oluşturduğumuz bir değerin değeri değiştirlmesi isteniyorsa bu durumda with yapısını kullanabilmekteyiz
            myRecord myRecord2=myRecord with { Yasi=99};
            Console.WriteLine(myRecord.Yasi);
            #endregion 
        }
      
        //classlara nazaran objenin datalarını sabitleyerek nesneden ziyade dataları ön plana çıkarmaktadır
        //equals gibi iki değer karşılaştırılırsa class yapısı içi aynı olsada false dönerken record'da true dönecektir
        public record MyRecord //recordlar bir class yapılanmasıdır
        {
            public string Name { get; init; }
            public int Yasi { get; init; }
            public void X() { }
        }
    }
 
    

   
}