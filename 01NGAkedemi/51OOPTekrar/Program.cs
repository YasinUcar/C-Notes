int y = 10;
X(ref y);
System.Console.WriteLine(y);
void X(ref int a)
{
    a = 25;
}

