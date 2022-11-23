namespace Static
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Abstract Class : Bir kalıtım yapılacak class'da öğelerin veya metotların kalıtım yapılan yerlerde mecbuen kullanılması isteniyorsa bu anahta kullanılır
        }
        abstract class AbstractClass
        {
            public abstract void Deneme();
        }
        class MyClass : AbstractClass
        {
            //artık burada deneme metodunu mecburen çağırmalıyız çağırmazsak hata verir
            public override void Deneme() //override kullanılmalıdır
            {
                
            }
        }
       
    }
    #endregion
}