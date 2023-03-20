#region  Array değer yazma okuma
Array deneme1 = new int[] { 45, 10, 150 };
Array deneme2 = new int[deneme1.Length];
deneme1.SetValue(30, 0);
Console.WriteLine(deneme1.GetValue(0));
#endregion

#region  clear = dizinin değerlerini default hale getirir
//Array.Clear(deneme1,0, deneme1.Length);
Console.WriteLine(deneme1.GetValue(0));
#endregion

#region copy = başka diziye kopyalama işlemini gerçekleştirmeye yarar bu bir klonlama değildir bu bir kopyalamadır
Array.Copy(deneme1, deneme2, deneme1.Length);
#endregion

#region indexOf = dizi içerisinde bir eleman var mı yok mu sorgulayabiliriz varsa index numarasını döndürür yoksa -1 döndürür
int varMi = Array.IndexOf(deneme1, 25);
if (varMi != -1) Console.WriteLine("vardir");

int varMi2 = Array.IndexOf(deneme1, 35, 0, 2); //verilen aralıkta mevcutMu
#endregion

#region  Reverse = diziyi tersine sıralar 
Array.Reverse(deneme1);
#endregion

#region Sort Fonskiyonu küçükten büyüye array'i sıralmamıza yarar
Array.Sort(deneme1);
Console.WriteLine("sıralama");
for (int i = 0; i < deneme1.Length; i++) Console.WriteLine(deneme1.GetValue(i));
#endregion