using System;

namespace AB
{
    //namespace는 수많은 class들을 편리하게 관리할 수 있게 한다.
    class A
    {
        
    }

    class B
    {

    }
}

namespace AB.CD
{
    //namespace는 계층적으로 구성될 수 있다.
    class C
    {

    }

    class D
    {

    }
}

class NameSpace
{
    static void main(string[] args)
    {
        System.Console.WriteLine("AA");
        //namespace 선언 없을 경우 참조
        Console.WriteLine("AA");
        //namespace 선언했을 경우 
    }

}

