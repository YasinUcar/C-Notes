using System.Text.RegularExpressions; //gerekli kütüphane
//
#region ^ ifadesi satır başının istenilen ifadede olup olmadığını söyler
string text = "91312312";

Regex regex = new Regex("^9");
Match match = regex.Match(text); //karşılaştır Match döndürür


bool dogruMu = match.Success;
Console.WriteLine(dogruMu);
#endregion

#region / Operatörü
// \D : Metinsel değerin ilgili yerinde rakam olmayan tke bir karakterin bulunması gerektiğini bildirir
// \d : Metinsel değerin ilgili yerinde 0-9 arasında tek bir sayı olacağını ifade eder

// \W : Metinsel değerin ilgili yerinde alfanümerik olmayan karakterin olması gerektiğini belirtir a-z A-Z 0-9
// \w : Metinsel değerin ilgili yerinde alfanumerik olan karakterin olacağını ifade eder.

// \S : Metinsel değerin ilgili yerinde boşluk karakterleri (Tab-Space) dışında herhangi bir karakterin olmayacağını belirtir.
// \s : Metinsel değerin ilgili yerinde sadece boşuk karakterin olacağı ifade edilir.

//TODO : 9 ile başlayan 2.karakteri herhangi bir sayı olan ve 3. karakteri boşuk olmayan bir ifade
string yazi = "92a34";
Regex regex1 = new Regex(@"^9\d\S"); //@ verbatim ile bunu ezdik
Match match1 = regex1.Match(yazi);
Console.WriteLine(match1.Success);
#endregion

#region + operatörü belirtilen gruptaki karakterin bir yada daha fazla olmasını istiyorsak kullanılır
//TODO : 9 ile başlayan arada herhangi bir sayısal değeri olan  ve son değeri boşluk olmayan bir ifade
Regex regex2 = new Regex(@"^9\d+\S"); //+ 2.ve sonrasında nümerik karakter aramasına yarar 1 den fazla olması yeterli bu ifadeden sonrada boşluk olmasın
Match match2 = regex2.Match(yazi);
Console.WriteLine(match2.Success);

#endregion

#region | veya  baş harfi a yada b yada c olan metinsel ifade
string yazi3 = "zcumali";
Regex regex3 = new Regex(@"^a|^b|^c");
Match match3 = regex3.Match(yazi3);
Console.WriteLine(match3.Success);
#endregion

#region {} sabit sayıda karakter olmasını istediğimiz durumlarda örneğin telefon numaralarında kullanılır
//536-9827712

string yazi4 = "536-9827712";
Regex regex4 = new Regex(@"\d{3}-\d{6}");
Match match4 = regex4.Match(yazi4);
Console.WriteLine(match4.Success);
#endregion

#region ? bu karakterin önüne gelen karakter en fazla bir en az sıfır defa olabilmektedir
string soruİsareti = "133BA";
Regex regex5 = new Regex("\\d{3}B?A");
Match match5 = regex5.Match(soruİsareti);
Console.WriteLine("Soru işareti: " + match5.Success);
#endregion

#region \\B or \\b
string byi = "dır";
Regex regex6 = new Regex("dır\\B");
Match match6 = regex5.Match(byi);
Console.WriteLine("Büyük B işareti: " + match6.Success); //false döner çünkü B başta sonda bu kelime yoksa true döner
#endregion

#region [n] : Karakter aralığını belirtir yani [A-E] arasında gibi bir ifade kullanabiliriz
string yazi5 = "ABE";
Regex regex7 = new Regex("[A-E]");
Match match7 = regex7.Match(yazi5);
Console.WriteLine("[n] işareti: " + match7.Success); //büyük küçük farkı mevcut
#endregion
