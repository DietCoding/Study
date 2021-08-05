using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Event
{
    class Handler
    {
        //이벤트 정의
        //이벤트는 =로 할당할 수 없고 +=, -=만 가능하다.
        public event EventHandler PrintHandler;    

        public void PrintLine()
        {
            if (this.PrintHandler != null)
                PrintHandler(this, EventArgs.Empty);
            //이벤트 호출
        }
    }

    static void main(string[] args)
    {
        Handler p = new Handler();
        //이벤트 핸들러에 함수 등록
        p.PrintHandler += Program_PrintHandler;
        //이벤트 발생
        p.PrintLine();
        p.PrintLine();
        p.PrintLine();
    }

    static void Program_PrintHandler(object sender, EventArgs e)
    {
        Console.WriteLine("클릭");
    }

    //델리게이트의 아무곳에서나 호출될 수 있고 값의 수정도 가능한 문제점을 보안하기 위한 것이 이벤트 입니다. 
    //예를들면 델리게이트는 대입연산이 가능하지만 이벤트는 불가능하구요. 추가 및 삭제만 가능합니다. 
    //또한 이벤트는 이벤트가 선언된 클래스 내부에서만 호출이 가능합니다.   
}

