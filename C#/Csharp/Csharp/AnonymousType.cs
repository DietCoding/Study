using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class AnonymousType
{
    static void main (string[] args)
    {
        //익명 타입 : 클래스를 정의하지 않고 사용할 수 있는 타입
        //읽기 전용이다. 
        var t = new { Name = "홍길동" };
        string s = t.Name;
        Console.WriteLine(s);
    }
}

