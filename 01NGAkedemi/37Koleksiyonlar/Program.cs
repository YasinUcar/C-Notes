using System.Collections;
#region ArrayList tanımlama arraylistler bir diziye ekleme çıkarma işlemini yapabilmemizi çok kolay sağalr
//değerleri object olarak tutar bu yüzden unboxing yapmak gerekir bu yüzden maliyetlidir
ArrayList yaslar = new ArrayList();
yaslar.Add(15);
yaslar.Add(19);
yaslar.Add("yazgi");
Console.WriteLine(yaslar[2]);
#endregion
//ikinci atama tarzı direk olarak atamaya izin verir
ArrayList arrayList = new ArrayList() { "Ahmet", 123, "Veli" };