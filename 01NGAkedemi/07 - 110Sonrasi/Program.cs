// See https://aka.ms/new-console-template for more information
Console.WriteLine("Lütfen Sayi Giriniz");
int sayi1 = int.Parse(Console.ReadLine());


int sonuc = sayi1 < 3 ? sayi1 * 5 : sayi1 > 3 && sayi1 < 9 ? sayi1 * 3 : sayi1 >= 9 && sayi1 % 2 == 0 ? sayi1 * 10 : sayi1 % 2 == 1 ? sayi1 : -1;
Console.WriteLine(sonuc);


