#region null - empty different
//bir değişken null olabilir eğer ki null alıyorsa bellekte yer tahsiz etmez
//empty olursa bu değiken alan yeri tahsis eder fakat içi boş olur 
//null değer verilmiş bir değerde işlem yapılmak istendiğinde run time'da hata verecektir
string isim = null;
string isim2 = string.Empty;

Console.WriteLine(isim);
Console.WriteLine(isim2);
#endregion

#region IsNullOrEmpty or Space
//elimizde ki string ifadenin işleme tabi tutulmadan önce kontrol edilmesi durumunda 
string x = " ";
bool emptyOrNull = string.IsNullOrEmpty(x); //if parametrelerinde kullanılabilir
Console.WriteLine(emptyOrNull);

bool dogruMu = string.IsNullOrWhiteSpace(x); //null empty veya boşluk durumunu kontrol eder
Console.WriteLine(dogruMu);

#endregion

string yazi = "Boş yere dönme dünya çift okey ben de ";
for (int i = 0; i < yazi.Length; i++)
{
    Console.Write(yazi[i]);
}


