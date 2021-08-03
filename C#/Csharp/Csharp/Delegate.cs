using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Delegate
{   
    delegate void Dele();    
    public delegate void Dele2(int i);

    void AddDele(int val)
    {
        val++;
        Console.WriteLine(val);
    }

    void SubDele(int val)
    {
        val--;
        Console.WriteLine(val);
    }

    void Perform()
    {
        Dele2 dele2 = new Dele2(AddDele);
        dele2(100);
        dele2 = SubDele;
        dele2(100);
    }

    void PrintParameter()
    {
        Delegate.Dele2 dele2 = AddDele;
        Delegate.PrintDeleParameter(dele2);
    }

    public static void PrintDeleParameter(Dele2 dele)
    {
        Console.WriteLine(dele.Method);
    }
    
    static void main(string[] args)
    {
        void Print1()
        {
            Console.WriteLine("p1");
        }
        void Print2()
        {
            Console.WriteLine("p2");
        }
        void Print3()
        {
            Console.WriteLine("p3");
        }
        Dele dele = new Dele(Print1);
        //delegate가 함수를 대리 호출한다.
        dele += new Dele(Print2);
        dele += new Dele(Print3);
        //+=로 delegate에 함수를 추가할 수 있다.
        dele();

        Delegate deleg = new Delegate();
        deleg.Perform();
        //동일한 파라미터와 리턴타입을 가진 메서드를 서로 호환해서 불러쓸 수 있다.

        deleg.PrintParameter();
        //delegate는 다른 함수의 파라미터로 사용될수 있으며
        //전달 받은쪽은 자신의 내부 함수 사용하듯이 쓸 수 있다.
        
    }
}
