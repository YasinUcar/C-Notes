Console.WriteLine(Kat(10, 20));
int Kat(int baslangic, int bitis)
{
    if(baslangic%5==0)
    {
        return baslangic + Kat(++baslangic, bitis);
    }
    if(baslangic<bitis)
    {
        return Kat(++baslangic, bitis);
    }
    return 0;
}