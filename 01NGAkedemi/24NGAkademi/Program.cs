int carpim = 1;
while (true)
{
    string girdi = Console.ReadLine();
    if (girdi == "t")
    {
        Console.WriteLine(carpim);
        break;
    }
    else
    {
        int sayi = int.Parse(girdi);
        if (sayi < 0)
            continue;
        carpim *= sayi;
    }


}
Console.Read();