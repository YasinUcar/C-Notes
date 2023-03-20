#region Sanal yapılanmalar base'de olan bir yapıyı tekrar bildirebildiğimiz değiştiebildiğimiz yapılardır
//davranışların kararı runtime'da verilmektedir. 
//bir sınıfta tanımlanmış olan member'ın kendisinden türeyen alt sınıflada ezilip/yeniden yazılması için kullanılmaktadır.
MyClass2 myClass2 = new();
myClass2.MyMethod(); //çıktı olarak merhaba dünya2 yi verecektir
class MyClass
{
    //artık bu sanal bir yapı oldu kalıtım alan bir sınıfta artık bu ezilebilir
    virtual public int Sayi1 { get; set; }
    virtual public void MyMethod()
    {
        System.Console.WriteLine("Merhaba dünya1");
    }
}
class MyClass2 : MyClass
{
    //virtual ile işaretlenmiş bir method veya değeri ezmek istiyorsak overide ı kullanmamız gerekir
    public override int Sayi1 { get; set; }
    public override void MyMethod() //override ile işaretlemesek name hidding olacaktı
    {
        System.Console.WriteLine("Merhaba dünya2");
    }
    //başka classlarda tekrar override edilip ezilirse hem burada hem diğer ezilen yerlerde kod blokları çalışacaktır
}
#endregion