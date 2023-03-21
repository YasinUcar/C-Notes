class ParaGonderici
{

}
interface IBanka
{
    bool ParaTransferleri(int tutar, string hesapNo);
}
class Garanti : IBanka
{
    public string HesapNo { get; set; }
    public void ParaGonder(int tutar)
    {

    }

    public bool ParaTransferleri(int tutar, string hesapNo)
    {
        try
        {
            HesapNo = hesapNo;
            ParaGonder(tutar);
            return true;
        }
        catch
        {
            return false;
        }
    }
}
class HalkBank : IBanka
{
    string _hesapNo;
    public void GonderilecekHesapNo(string hesapNo)
    {

    }
    public void Gonder(int tutar)
    {

    }
    public bool ParaTransferleri(int tutar, string hesapNo)
    {
        try
        {
            GonderilecekHesapNo(hesapNo);
            Gonder(tutar);
            return true;
        }
        catch
        {
            return false;
        }
    }
}