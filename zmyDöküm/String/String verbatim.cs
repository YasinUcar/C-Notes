#region düz toplama ile yazdırma
string yazi = "Yasin";
int yas = 24;
bool medeniHal = false;
Console.WriteLine("İsim :" + yazi + " Yasi: " + yas + " Madeni Hal: " + (medeniHal ? "Evli" : "Evli Değil"));
#endregion

#region string format eski kullanımlardan biridir indexirlar ile kullanılır
string cikti = string.Format("İsim : {0}  yasi: {1} medeni hal: {2}", yazi, yas, medeniHal);
Console.WriteLine(cikti);
#endregion

#region string $interpolation
Console.WriteLine($"İsim : {yazi} yas: {yas} medeni hal : {(medeniHal ? "Evli" : "Bekar")}"); //{} kullanmak için ez
#endregion

#region kaçış karakterleri \n \t \f vb. iki kere \\ ifadesi kullanılıp yazılırsa ezer ve çıktı verir.
Console.WriteLine($"İsim: {yazi} \nyas: {yas}");
Console.WriteLine("\a"); //bip sound :)
#endregion

#region @verbatim operatörü bir değişken yahut metot vs. gibi yapılandırmalarda kullanılır yasaklı şeylerde
int @int = 15;
Console.WriteLine(@int);
//ezmektede kullanılabilir
Console.WriteLine(@"Hava çok ""güzel"""); //alt alta içinde kullanılabilir

//verbatim + string interpolation
string mesaj =
@$"Merhaba {yazi}
Yasiniz {yas}
Evlilik durumu {medeniHal}";
Console.WriteLine(mesaj);
#endregion


