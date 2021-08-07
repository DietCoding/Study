using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Stack
{
    //스택은 가장 나중에 추가된 데이터가 먼저 출력된다.(한쪽 끝에서만 넣거나 빼는 구조)
    
    static void main(string[] args)
    {
        Stack<int> s = new Stack<int>();
        s.Push(1);
        s.Push(2);
        s.Push(3);
        int a = s.Pop();
        Console.WriteLine(a);
    }
}
