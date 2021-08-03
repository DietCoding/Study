using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MyList
{
    private int[] data = { 1, 2, 3, 4, 5 };
    
    public IEnumerator GetEnumerator()
    {
        int i = 0;
        while ( i < data.Length)
        {
            yield return data[i];
            i++;
        }
    }
}

class Yield
{
    static void main(string[] args)
    {
        var list = new MyList();

        //foreach문에서 자동으로 iterator 루프를 처리
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        //수동으로 IEnumerator을 생성해서 iteration
        IEnumerator it = list.GetEnumerator();        
        it.MoveNext();
        Console.WriteLine(it.Current);
        it.MoveNext();
        Console.WriteLine(it.Current);
    }
}

