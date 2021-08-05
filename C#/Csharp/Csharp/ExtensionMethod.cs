using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class ExtensionMethod
{
    //확장 메서드: 다른 클래스나 타입의 메서드처럼 사용 가능하다.
    //첫번째 파라미터는 어떤 클래스(타입)이 사용할지 지정
    public static int AddOne(this int a)
    {
        return ++a;
    }

    //이 메서드는 파라미터 sum을 필요로 함
    public static int AddSum(this int a,int sum)
    {
        return a + sum;
    }

    static void main(string[] args)
    {
        int i = 3;        
        int i2 = i.AddOne();
        Console.WriteLine(i2);
        //확장 메서드의 두번째 파라미터부터 실제 파라미터 값을 필요로 한다.
        int i3 = i.AddSum(4);
        Console.WriteLine(i3);
    }
}

