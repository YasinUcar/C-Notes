Array isimler = new string[] { "Ahmet", "Rıfkı", "Yasin", "Mehmet", "Şuayip" };
#region IsReadOnly sadece okunup okunmadığı durumlarını veren özelliktir sadece okunabilir olmasını istediğimiz diziler için kullanılır
Console.WriteLine(isimler.IsReadOnly); //bizim dizemiz hem okunabilir hem yazılabilir = false
#endregion

#region  IsFixedSize Veri kümesinin eleman sayısının sabit olup olmama durumunu öğrenebiliriz
#endregion

#region Rank bir dizenin çok boyutlu olup olmadığını çok boyutlunun kaç hane olduğunu veren özelliktir.
#endregion

Array yaslar2 = Array.CreateInstance(typeof(int), 5); //array oluşturmanın alternatif bir yolu alternatif


