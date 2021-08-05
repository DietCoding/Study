using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;


class DynamicType
{
    public void M1()
    {
        //ExpandoObject는 dynamic 타입에 속성,메서드,이벤트를 동적으로  쉽게 할당 도와줌
        dynamic a = new ExpandoObject();
        //속성 지정
        a.Name = "Kim";
        a.Age = 10;
        //메서드 지정
        a.Display = (Action)(() =>
        {
            Console.WriteLine(a.Name + "," + a.Age);
        });

        a.ChangeAge = (Action<int>)((age) =>
        {
            a.Age = age;
            if(a.AgeChanged!=null)
            {
                a.AgeChanged(this, EventArgs.Empty);
            }
        });
        //이벤트 초기화
        a.AgeChanged = null;
        //이벤트 핸들러 지정
        a.AgeChanged += new EventHandler(OnAgeChanged);
        M2(a);

        //ExpandObject를 IDictionary로 변환해서
        var dict = (IDictionary<string, object>)a;
        //IDictionary 해시테이블에 저장되어있는 속성,메서드,이벤트 출력
        foreach (var d in dict)
        {            
            Console.WriteLine("{0}: {1}", d.Key, d.Value);
        }
    }

    private void OnAgeChanged(object sender,EventArgs e)
    {
        Console.WriteLine("Age Changed");
    }

    public void M2(dynamic d)
    {
        d.Display();
        d.ChangeAge(20);
        d.Display();
    }

    static void main (string[] args)
    {
        DynamicType d = new DynamicType();
        d.M1();
    }
}

