#region Index
string[] isimler = { "Hüseyin", "Hilmi", "Rıfkı", "Hatice", "Ayşe", "Mahmut", "Kazım", "Okan", "Emre", "Ali", "Naci", "Hüsnü", "Kamil" };

Index i1 = ^3; //sağdan sola gittiği için sağdan 1 olarak alır ay ni kamil=1
Index i2 = 4; // soldan sağa n-1 alır yani hüseyin = 0 
Console.WriteLine(isimler[i2]);
Console.WriteLine(isimler[i1]);
#endregion

#region  Range 
// 3 ile 7 arasında çalışmak istiyorum ve bunları verdim burada sağdaki ifade yani 7 Kazım a denk gelir yani 1'den alır fakat sol 0 dan başlar haticeye gelir
Range range = 3..7;
var sayilar = isimler[range]; //yeni bir liste dizayn edip artık burada çalışabiliriz
Console.WriteLine(sayilar[0]); // = Hatice


#endregion

#region ^ operatörü tersten veri okumamıza yarar index türü gerekir 
string[] yazilar = { "Mehmet", "Ali", "Zeynep", "İsmail" };
Console.WriteLine("^ tersten");
Console.WriteLine(yazilar[^1]);

#endregion
Console.ReadLine();