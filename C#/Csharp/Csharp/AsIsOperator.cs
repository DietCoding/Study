using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MyBase { }
class MyClass : MyBase { }

class AsIsOperator
{
    static void main(string[] args)
    {
        MyClass m = new MyClass();
        new AsIsOperator().Test(m);
    }

    public void Test(object obj)
    {
        //as:객체를 지정된 클래스로 변환 
        //변환 성공시 지정한 클래스로 변환, 실패하면 null return
        MyBase a = obj as MyBase;

        //is:객체가 특정 클래스타입이나 인터페이스 갖고있는지 확인
        bool ok = obj is MyBase;

        if(ok)
        Console.WriteLine("obj는 MyBase");
    }
}

