#region  Generic yapılar bir class'ın birden fazla değer alabilmesine oalnak vermektedir

List<string> yeniListe = new List<string>(); //örneğin bu bir generic yapıdır bir çok öğe ile liste kullanabiliriz


MyList<int> my = new MyList<int>();

my.Add(15);
my.Add(35);
my.Add(15);

System.Console.WriteLine(my.Count);



#endregion

class MyList<T>
{
    T[] _array;
    T[] _tempArray;
    public MyList() //const
    {
        _array = new T[0]; //başlangıçta listeler 0 eleman lıdır ve bizde program başladığında 0 elemanlı bir eray başlattık
    }

    public void Add(T item)
    {
        //arraylerin çalışma mantığına göre tekrar yaratılması gerekiyor yeni bir array oluşturursak önceki verileri siler önceki veri hafızada tutulur ama bu yeni ref oluşturur
        //bu yüzden verinin yedeğini almamız ve tekrar eklemiz gerekir

        _tempArray = _array; //refini alıyor 101 
        _array = new T[_array.Length + 1]; //102 ref oldu

        for (int i = 0; i < _tempArray.Length; i++)
        {
            _array[i] = _tempArray[i];
        }
        _array[_array.Length - 1] = item; //lenght tam sayıyı verdiği için -1'i alıyoruz



    }

    public int Count
    {
        get { return _array.Length; }

    }


}