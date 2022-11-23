#region out keyword : metotların parametreleri üzerinden dişariya değer göndermmeizi sağlayan bir keywordür

void X(out int sayi, int c, out string d) //out dışındada değeler alabilirler fakat outlara değer vermek zorunludur
{
    sayi = 5;
    d = "Mehmet";
}
#endregion
#region Kullanım1 atama
string isim = "";
int sayi = 0;
X(out sayi, 5, out isim); //dışarıya gönderiken de out keywordü kullanmak gerekir diğer türlü değişkenlerin değerini yollamaya çalışır
Console.WriteLine(isim);
Console.WriteLine(sayi);
#endregion

#region  Kullanım2 daha hızlı yol 

X(out int sayi1, 5, out string isim1);
Console.WriteLine(sayi1);
Console.WriteLine(isim1);

#endregion
