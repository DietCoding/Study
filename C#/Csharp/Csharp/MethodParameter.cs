using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MethodParameter
{
    void Add(int a)
    {
        //메서드에 인수를 전달할 때 값을 복사해서 전달        
        a++;
    }

    void RefAdd(ref int a)
    {
        //메서드에 파라미터를 레퍼런스(참조)로 전달 
        a++;
    }

    void OutAdd(int ini,out int a)
    {
        //out은 메서드내에서 값을 반드시 지정해야 함
        a = ini;
        a++;
    }

    static void main(string[] args)
    {
        MethodParameter m = new MethodParameter();
        int val = 1;
        //ref로 전달되는 변수는 사전에 초기화되어야함
        m.Add(val);
        Console.WriteLine(val);
        //val = 1
        //전달된 인수를 메서드 내에서 변경해도 인수 값은 원래값 그대로 유지
        m.RefAdd(ref val);
        Console.WriteLine(val);
        //val = 2
        //ref를 사용할 경우 변경된 값은 리턴 후에도 유효
        int val2;
        //out으로 전달되는 변수는 사전에 초기화되지 않아도 됨
        m.OutAdd(val,out val2);
        Console.WriteLine(val2);
        //val = 3
        //out도 변경된 값은 리턴후에도 유효        
    }
}
