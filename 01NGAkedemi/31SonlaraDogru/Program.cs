//Adı ilkten 3 sondan 5. n ve ı yı getirsin

string adSoyad = "Gençay Yıldız";
#region düz çözüm
Console.WriteLine(adSoyad[2]);
Console.WriteLine(adSoyad[adSoyad.Length - 4]);
#endregion
#region Range ile çözüm
string aralik = adSoyad[2..^4]; //^ değeri n+1'ini alır yani burada aslında 5. yi alıyor
Console.WriteLine(aralik[0]);
Console.WriteLine(aralik[aralik.Length - 1]);
#endregion


#region girilen metinin içinde kaç tane n harfi geçtiğini hesaplayalım
string mesaj = Console.ReadLine();
int sayi1 = 0;
for (int i = 0; i < mesaj.Length; i++)
{
    if (mesaj[i] == 'n')
    {
        Console.WriteLine(sayi1++);
    }
}
#endregion
int kelimeSayisi=0;
#region Girilen metnin kelime sayisini hesaplayalım 
string[] dizi = mesaj.Split(' ');
foreach (string i in dizi)
{
kelimeSayisi++;
}
Console.WriteLine("Kelime sayisi: " + kelimeSayisi);
#endregion