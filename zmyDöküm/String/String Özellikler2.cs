#region contains Bu kelime var mı 
string yazi1 = "Yasin Ucar";
bool deneme = yazi1.Contains("y".ToUpper());
Console.WriteLine(deneme);
#endregion

#region StartWidth  verilen kelime ile mi başlıyor diye kontrol eder EndsWith = sonunu kontrol eder
Console.WriteLine(yazi1.StartsWith("Yas"));
Console.WriteLine(yazi1.EndsWith("ar")); //true
#endregion

#region Equals elimizdeki ifade ile başka ifadenin eşit olup olmadığını kontrol eder
Console.WriteLine(yazi1.Equals("Yasin Ucar"));
#endregion
#region Compare metinsel değerleri kendi arasında karşılaştırmak için int döner
string yazi2 = "a";
string yazi3 = "z";
//0.Her iki değer birbirine eşit 1 : Soldaki sağdakinden alfanumerik olarak büyük -1 : Soldaki sağdakinden alfanumerik olarak küçükse
Console.WriteLine(string.Compare(yazi2, "z")); //-1 
//compare to : 
Console.WriteLine(yazi2.CompareTo(yazi3)); //-1 
#endregion

#region IndexOf verilen char'ın kaçıncı indexde olduğunu söyler yoksa -1 
Console.WriteLine(yazi1.IndexOf("s"));//2
Console.WriteLine(yazi1.IndexOf("Uca"));//6 başlangıç noktası

#endregion
#region Insert metne değer ekler verien indexde başlar || Remove : kaldırır
Console.WriteLine(yazi1.Insert(6, "carcar")); //Yasin carcarUcar
Console.WriteLine(yazi1.Remove(0, 6));//Ucar

#endregion

#region Replace elimizde olan string'i içindekileri değiştirmeye yarar
Console.WriteLine(yazi1.Replace("Ya", "Ma")); //Masin Uçar;
#endregion

#region Split metinsel ifadeyi verilen değeri ayraç olarak kullanıp parçalayan ve sonucu dizi olarak döndüren fonksiyon
string[] dizi = yazi1.Split(' '); //boşuk verdik böylece her boşluktan sonra dizileri atar yani dizi[0] = Yasin dizi[1] = Ucar olur

#endregion

#region Substring elimizdeki bir string ifadenin belirli bir bölümünü almamızı sağlar
Console.WriteLine(yazi1.Substring(6)); //6. indexten sonrasını bana getir Ucar olur
Console.WriteLine(yazi1.Substring(0, 2)); //Ya 2.ifade uzunluk index değil
#endregion

#region Trim  baş ve sonda bulunan boşlukları silmemize yarar TrimStart veya end de kullanılabilir
string yazi4 = " ahmet pekyemez ";
Console.WriteLine(yazi4.Trim()); //başta ve sonda olan boşlukları kaldır aralara dokunmaz
#endregion