using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Indexer
{
    //indexer : 클래스객체를 배열처럼 []을 사용하여 클래스내 필드데이터에 엑세스
    private int[] data = new int[10];

    public int this[int index]
    {
        get
        {
            return data[index];
        }

        set
        {
            data[index] = value;
        }
    }
}

class Indexer_Program
{
    static void main(string[] args)
    {
        Indexer indexer = new Indexer();
        indexer[3] = 100;
        int i = indexer[3];
        Console.WriteLine(i);
    }
}

