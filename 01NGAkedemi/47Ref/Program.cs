#region ref returns : sadece metotlarda kullanılabilmektedir  
int a = 5;
int b = Sayi(ref a);
ref int Sayi(ref int y)
{
    y = 25;
    return ref y;
}
Console.WriteLine(b);
#endregion