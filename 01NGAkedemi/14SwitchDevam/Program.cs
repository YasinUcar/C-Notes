namespace _14SwitchDevam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string yazi, int ahmet) c = ("Yasin", 24);
            string mesaj = "";
            switch (c.yazi,c.ahmet) //böyle kullanmak istedim
            {
                case ("Ahmet", 25):
                    mesaj="Ahmettir ve yaşı 25'tir";
                    break;
                case ("Yasin", 24):
                    mesaj = "Yasindir ve yaşı 24'tür";
                    break;
            }
            Console.WriteLine(mesaj);
            #region örnek2
            string adi = "Mehmet";
            int yasi = 27;
            string mesaj1 = (adi, yasi) switch
            {
                ("Hüseyin",20)=>mesaj="Hoşgeldin hüso",
                ("Mehmet",27)=>mesaj="Hoşgeldin memo",
            };
            Console.WriteLine(mesaj1);
            #endregion
        }
    }
}