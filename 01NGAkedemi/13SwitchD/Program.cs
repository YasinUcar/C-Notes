namespace _13SwitchD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region SwitchExpressions (Tek Satırlık işlemlerin yazmımını kolaylaştırır
            string mesaj = DateTime.Now.DayOfWeek switch
            {
                DayOfWeek.Monday => "Pazartesi",
                DayOfWeek.Thursday => "Perşembe"
            };
            Console.WriteLine(mesaj);

            #endregion
            #region when şartı
            string gunler = DateTime.Now.DayOfWeek switch
            {
                var x when x==DayOfWeek.Monday && 3==4 => "Bu gün günlerden Pazartesi",
                var x when x == DayOfWeek.Thursday => "Bu gün günlerden Perşembe"
            };
            Console.WriteLine(gunler);
            #endregion

            #region when şartı 2 
            int i = 10;
            string isim = i switch
            {
                5 when 3==3=>"Hilmi",
                var x when x==7 && x%2==1 =>"Memoli",
                20=>"Ahmetli",
                var x=>"Hiçbiri"//default
            };
           
           #endregion

        }

    }
    }
