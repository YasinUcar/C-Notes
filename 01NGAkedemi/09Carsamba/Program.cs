#region nullable : değer türlü değişkenlerin null değer alabilmeleri için nullable olması için ? kullanılır
int? a=null;
Console.WriteLine(a);
#endregion

//ornegin

object x = 123;
int? y = x as int?;//int null dönme ihtimaline karşı bu kullanılır diğer türlü unboxing yapılmaz
Console.WriteLine(y);