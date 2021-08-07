using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LinkedList
{
    //링크드 리스트는 데이터를 포함하는 노드들을 연결하여 만든 자료구조로
    //각 노드는 데이터와 다음/이전 링크 포인터를 갖게 된다.
    static void main(string[] args)
    {
        LinkedList<string> list = new LinkedList<string>();
        list.AddLast("One");
        list.AddLast("Two");
        list.AddLast("Four");

        LinkedListNode<string> node = list.Find("Two");
        LinkedListNode<string> newNode = new LinkedListNode<string>("Three");

        //새 노드 Three를 Two노드 다음에 추가
        list.AddAfter(node, newNode);
        list.ToList<string>().ForEach(p => Console.WriteLine(p));
    }
    

}

