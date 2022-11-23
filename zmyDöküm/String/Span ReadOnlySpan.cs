#region Span arraysegment stringsegment den ziyade tüm alanlarda kullanılbailir
string yazi = "Merhaba Dünya Nasılsın";
int[] sayilar = { 10, 20, 30, 40, 50, 60 };
//Span<int> span = new Span<int>(sayilar); //refere ediyor
Span<int> span = sayilar; //yukarıdaki durumun kısaltılmış hali
Span<int> aralikli = new Span<int>(sayilar, 2, 2); //burda kullanılan yapıda 2.indexten başlar ve ondan itibaren 2 tane lenght alır yani 30 ve 40
Span<int> span4 = sayilar.AsSpan(); // alternatif olarakta bu kullanılabilir


ReadOnlySpan<char> radOnlySpan = yazi.AsSpan(); //string'de readonly çalışmak gerekir

#endregion