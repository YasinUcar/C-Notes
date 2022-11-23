namespace _50OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region property : esasında bir mettotur fiziksel olarak farklı parametre almamakta ve içerisinde get ve set olarak iki adet blok bulunmaktatır.
            //nesnelere (fieldlara) direk olarak erişilmeyi istemeyiz verileri kontrollü bir şekilde dışarıya aktarmak için property (Get-set) mantığı kullanılır diğer
            //programlama dillerinde bu metotlar ile yapılabilirken c# burada hem metot hem property özelliğini destekelmektedir bu durumda field private yapılır kontrollü verilir
            //bu duruma Encapsulation(Kapsülleme/Sarmalama) denmektedir.
            MyClass myClass = new MyClass();
            myClass.Sayi1 = 65;
            System.Console.WriteLine(myClass.Sayi1);
            myClass[5] = 10;//indexer

            #endregion
        }
        class MyClass
        {
            private int sayi1; //dışardan erişilmesine gerek yok property ile bu işlemi gerçekleştireceğiz
            string yazi1;

            #region FullProperty : hem get hem set yazılabilir ve okunabilir property'ler
            public int Sayi1 //genel olarak property'lerin ismi field'ın büyük harfiyle başladığı durum olarak tanımlanır
            {
                //get bloğu tanımlanmazsa sadece yazılabilir write only olacaktır
                get  //property'den veri istendiğinde tetiklenir okuma
                {
                    return sayi1;
                }
                //set tanımlanmadığı durumda sadece okunabilir readonly yapı olur
                set  //property'ye değer gönderilmek istendiğinde tetiklenir yazma
                {
                    sayi1 = value; //buradaki value metodun değerini direk olarak alır yani int
                }

            }
            public string Yazi1
            {
                get
                {
                    return yazi1;
                }
                set
                {
                    yazi1 = value;
                }
            }
            #endregion
            #region PropProperty hiç müdahale olmayacaksa kullanılabilir full prop kısa yolu
            //Proplar readonly olabilir lakin writeonly olamaz
            //direk olarak değişkeni public yapmak yazılım ahlakı olarak tavsiye edilmez
            //değiken yoksa prop otamatik olarak arka planda bunu bir değişkene atar
            public int Sayi2 { get; set; }
            // get=>sayi1; set=>sayi1=value; // diyerek değişken atanabilir fakat bu full propa girer
            #endregion
            #region Auto Property Initializers //prop proplarda oluşturulan değişkenlerin default değerlerini atamamızı sağalr
            public string soyadi { get; set; } = "Ucar";
            #endregion
            public string Cinsiyet => "Erkek"; //just readOnly lambda get'in kısa yolu

            #region Indexer
            public int this[int a]//this keywordü gereklidir
            {
                get
                {
                    return a;
                }
                set
                {

                }
            }
            #endregion
        }

    }
}

