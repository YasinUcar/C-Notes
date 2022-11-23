#region  Bir nesnenin birden fazla türle referansla işaretlenmesi aynı tür tarafından karışalanabilmesi durumu
//bir nesne başka bir nesne ile işaretlenmek/referans edilmek isteniyorsa arada kalıtımsal bir ilişki olması gerekir
//poliforzim ile nesne birden fazla türün davranışlarını gösterebilmemizi sağlar

MyClass2 my = new MyClass();
A b = new B();
B b1 = new B();
C b2 = new B();
class MyClass : MyClass2 //burada ise en büyük en üst taraf altlarını referans etmesi gerekir
{

}
class MyClass2
{

}
#endregion

#region örnek1 

class A : C
{

}
class B : A
{

}
class C
{

}
#endregion
