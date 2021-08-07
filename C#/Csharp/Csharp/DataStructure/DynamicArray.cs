using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Concurrent;

class DynamicArray
{
    static void main(string[] args)
    {
        //arraylist는 모든 요소가 object타입으로  리턴
        ArrayList myList = new ArrayList();
        myList.Add(10);
        myList.Add(20);
        myList.Add(30);
        //object타입이기때문에 int로 캐스팅
        int a = (int)myList[0];

        List<int> myList2 = new List<int>();
        myList2.Add(10);
        myList2.Add(20);
        myList2.Add(30);
        int b = myList2[0];

        SortedList<string, int> myList3 = new SortedList<string, int>();
        myList3.Add("제주완", 23);
        myList3.Add("홍정필", 24);
        myList3.Add("윤홍근", 21);
        int c = myList3["제주완"];

        var bag = new ConcurrentBag<int>();
        bag.Add(10);
        bag.Add(20);
        bag.Add(30);
        int check = 0;
        //TryPeek은 내용을 확인만 한다
        bag.TryPeek(out check);
        Console.WriteLine(check);
        Console.WriteLine("개수:{0}", bag.Count);
        //TryTake는 내용을 확인하고 컨테이너 안에서 삭제한다
        bag.TryTake(out check);
        Console.WriteLine(check);
        Console.WriteLine("개수:{0}", bag.Count);
    }
}

