namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Init-Only Properties : Bu özellik sayesinde sadece readonly olduğu halde değer atanmaya çalışan propertilerin hata vermemesini sağlayabiliriz
            MyClass m1 = new()
            {
                MyProperty = 20,
                Name = "Ahmet", //init ile set gibi kullanabildik
            };
            Console.WriteLine(m1.MyProperty);
            m1.MyProperty = 25;//Bunda hata verecektir çünkü init ile birlikte sadece başta değer verebilmekte daha sorna değer verebilmeyi kısıtlamış oluruz
            


        }
    }

    class MyClass
    {
        public readonly string name = "Ahmet";
        public int MyProperty { get; init; } //init eklememiz gerekiyor
        //readonly değere veri atmak sadece başlangıçta
        public string Name
        {
            get
            {

                return name;
            }
            init
            {
                name = value;
            }
        }
    }
    #endregion
}