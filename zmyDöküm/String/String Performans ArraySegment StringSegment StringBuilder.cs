using Microsoft.Extensions.Primitives;
using System.Text;
#region  Array Segment = bir dizinin bütününden ziyade belirli bir kısmına bağımsız bir şekilde refarns ile erişmemizi salt şekilde temsil etmemizi sağlar
int[] sayilar = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
ArraySegment<int> segment1 = new ArraySegment<int>(sayilar); //türetmez veya çoğaltmaz referans eder
ArraySegment<int> segment2 = new ArraySegment<int>(sayilar, 2, 5);
segment1[0] = 1000;
for (int i = 0; i < sayilar.Length; i++)
{
    Console.WriteLine(sayilar[i]);
}
//dilimleme belirli aralığı farklı aralıklara dilimleyebiliriz 
ArraySegment<int> yeniSegment = segment1.Slice(0, 3);

#endregion

#region StringSegment dizinin belirli bir alanını refarns etmek için kulalnılır string'in kendi metodları olduğu için arraysegment yerine türetilmiştir primitives kütüphanesi gerekir
string yazilar = "Boşuna dönme dünya çift okey ben de ";
StringSegment yazilar1 = new StringSegment(yazilar, 2, 5); //Substringe göre daha performanslıdır çünkü sadece refarans değerleri kullanılır yeni değer oluşmaz
Console.WriteLine(yazilar1);
#endregion
//stringBuilder yüksek maliyeti absorve etmek için stringSegment algoritmasını kullanır System.Text kütüphanesi gerekir
#region  StringSegment ikiden fazla ifadeyi string olarak toplamamız gerekiyorsa bu maliyeti arttırır çünkü her seferinde yeni bir string değeri ile ramde fazladan yer kaplar bunun için stringbuilder var
string isim = "Yasin";
string soyad = "Uçar";
StringBuilder builder = new StringBuilder(); //class
builder.Append(isim);
builder.Append(" "); //arada boşluk olsun
builder.Append(soyad);
Console.WriteLine(builder);

#endregion
