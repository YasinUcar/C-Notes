string adi = "Mehmet";
int yasi = 25;

string mesaj = (adi,yasi) switch
{
    ("Hüseyin",25)=>"Hoşgeldin hüso",
    ("Mehmet",25)=>"Hoşgeldin memo"
};
Console.WriteLine(mesaj);