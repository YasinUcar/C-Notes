// See https://aka.ms/new-console-template for more information
#region Ternary
//bir değişkene metoda property'e eğer ki şarta göre fark ediyorsa kullanılabilir tek satır
//atanan işlemlerin ikiside aynı olmalıdır
bool madeniHal=true;

 string mesaj = madeniHal==true ? "Evlilere Kampanya " : "Kampanya Falan Yoktur";
Console.WriteLine(mesaj);
 //birden fazla şart olayı 
int yas=25;
string mesaj2  = yas<25 ? "A" : yas==25 ? "B" : "C";
Console.WriteLine(mesaj2);





 
#endregion
