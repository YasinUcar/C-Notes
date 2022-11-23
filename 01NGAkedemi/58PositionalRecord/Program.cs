#region Positional Record : Recordlar içerisinde tanımlama yapabileceğimiz constructor ve deconstructor kullanımlarını daha da özlelleştirerek kullanmamamızı sağlar

MyRecord m1 = new MyRecord("yasin", "ucar");
var (isim, soyisim) = m1;//decons ile hızlı bir şekilde aldık tanımlananları


record MyRecord(string name, string surname) //decons ve cons karşılığı () içine tanımlanır
{
    //eğer positional record tanımlanmışsa bunlar kullanılmak zorundadır
    public MyRecord() : this("yasin", "ucar")
    {
        System.Console.WriteLine("Merhaba dünya");
    }
}

#endregion