using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class AnonymousMethod
{
    //무명 메서드: delegate에서 메서드를 지정할 때 메서드를 미리 정의하지 않아도 됨
    //형식 : delegate(파라미터){실행문장};
    delegate int CalOne(int i); 
    
    static void main (string[] args)
    {
        CalOne calOne = null;       
        calOne = delegate (int a) { return ++a; };
        Console.WriteLine(calOne(1));
    }
}

