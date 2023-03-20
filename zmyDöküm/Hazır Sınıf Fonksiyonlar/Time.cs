#region DateTimeNow : Şimdiki zamanı döndüren özelliktir sadece değer döndürür
Console.WriteLine(DateTime.Now);
Console.WriteLine(DateTime.Now.DayOfWeek);
Console.WriteLine(DateTime.Now.DayOfYear);
Console.WriteLine(DateTime.Now.Year);
Console.WriteLine(DateTime.Now.Minute);
#endregion

#region Today Sadece tarih bilgisini getiren özellik
Console.WriteLine(DateTime.Today);
#endregion

#region Compare : İki tarihsel veri arasında sorgulama yapmaya yarar.
DateTime day1 = new DateTime(2022, 01, 01);
DateTime day2 = new DateTime(2021, 01, 01);
Console.WriteLine(DateTime.Compare(day1, day2)); //int döner 1 dönerse birinci tarih 2.den büyük -1 dönerse 2.tarih büyük anlamına gelir 0 gelirse eşittir anlamına gelirMath.in
#endregion

#region Add Day hours moth years vb. kullanarak mevcut tarihe + değer ekleyebiliriz.
Console.WriteLine(DateTime.Now.AddYears(1));
#endregion

#region TimeSpan : iki tarih arasında farkı alabiliriz.
DateTime t1 = DateTime.Now;
DateTime t2 = new DateTime(2000, 1, 1);
TimeSpan span = t1 - t2;
Console.WriteLine(span.Days); //gün olarak ne kadar fark varı verir
#endregion