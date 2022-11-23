int sayi = int.Parse(Console.ReadLine());
int fak = 1;
string yazi = "";

for(int i=1;i<=sayi;i++)
{
    fak *= i;
    yazi += i+ (i==sayi?  " = " : " x ");
    
}
Console.WriteLine("Faktoriel: "+yazi+ fak);
