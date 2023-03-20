#region Kalitim : Aynı aile grubundan gelen nesnelerin benzer olgularını özelliklerini tekrar tekrar tanımlamak yerine bir üst sınıfta tanımlanmasını ve her bir sınıfın 
//bu özellikleri üst sınıftan kalıtımsal olarak almasını ifade eder
//meselea insan ve hayvanın ortak noktaları olduğunu düşünürsek bunları teker teker tekrar tanımlamaktansa bunları canlı nesnesinden türetmek daha mantıklı olacak kod tekrarını engelleyecektir

#endregion

class BuyukBabaa
{
    public int Yas { get; set; }
}
class Baba : BuyukBabaa
{
    public int MyProperty { get; set; }
}
class Ogul : Baba //sıralı şekilde gidecektir yani nesne oluşturma önce baba'ye gidecek oradan buyukbabaya gidecek ve üstten alta doğru nesneleri oluşturacaktır
{
}

//cons. olduğunu varsayalım ve bu ilk değer kabul etsin
class MyClass
{
    public int Yasi { get; set; }
    public MyClass(int a)
    {

    }

    // public MyClass() //bunu kullanırsak aşağıda tanımlama yapmamıza gerekmez bunu default olarak alır
    // {

    // }
}
class MyClass2 : MyClass //myClass'dan kalıtım alıyor haliyle parametreyi vermemiz gerkir
{
    public MyClass2() : base(5) //burada base anahtarını kullanıp erişiyoruz böylece base class'a erişiyor 
    {

    }
    private void X()
    {
        //this ve base farkı
        base.Yasi = 15; //base keywordü ile proplarada böylecek erişebiliriz
        this.Yasi = 20; //bu durumda ise kalıtımdan gelen kendi değerini değiştirmektedir
    }
}