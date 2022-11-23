#region class oluşturma : classlar bir referans türüdür


OrnekModel ornek = new OrnekModel();



class OrnekModel
{
    int sayi1; //bunlar field dir
    string isim;
    public void X()
    {
        Console.WriteLine(sayi1 + " " + isim);
    }
    public int Y()
    {
        return sayi1 * 2;
    }
}


#endregion
