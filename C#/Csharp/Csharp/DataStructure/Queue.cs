using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Queue
{
    //큐는 먼저 추가된 데이터가 먼저 출력된다.
    //Queue클래스는 순환배열로 마지막요소에 다다른 경우 다시 배열 처음요소로 순환한다.
    //head와 tail포인터를 가지고 있는데 tail에 데이터를 추가하고 head에서 데이터를 읽고 제거한다.

    static void main(string[] args)
    {
        Queue<int> q = new Queue<int>();
        q.Enqueue(10);
        q.Enqueue(20);
        q.Enqueue(30);
        q.Dequeue();//10제거
        q.Dequeue();//20제거        
    }
    
}

