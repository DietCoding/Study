using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Property
{
    //c#에서는 getter/setter따로 만들필요 없이 
    //프로퍼티의 get/set 접근자를 이용하는 것이 좋다.
    //get만 만들면 읽기전용, set만 만들면 쓰기 전용이 된다.
    private int x;
    public int X
    {
        get { return x; }
        set { x = value; }       
    }

    //Auto Property: 컴파일러가 자동으로 private를 생성해줌 
    //아래와 같이 get;set;접근자를 사용할 때만 적용 
    public int autoX { get; set; }
}

class Property_Program
{
    static void main(string[] args)
    {
        Property p = new Property();
        //set접근자로 x의 값 지정
        p.X = 22;
        //get접근자로 x의 값 읽어옴
        Console.WriteLine(p.X);
    }
}

//property vs public field
//프로퍼티는 데이터바인딩이 가능하고
//값을 넣을 때 특별한 처리 명령이 가능하다


