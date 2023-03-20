Random random = new Random();


int randSayi = random.Next(0, 500);//0 la 500 arası sayı üret asla 0 ı ve 500 ü dahil etmez bunu istiyorsa -1 ve 501 arası döndürmemiz gerekir
Console.WriteLine(randSayi);

double randDouble = random.NextDouble();
Console.WriteLine(randDouble);

