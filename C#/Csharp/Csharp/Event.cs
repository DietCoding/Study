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
        public event EventHandler PrintHandler       

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
}

