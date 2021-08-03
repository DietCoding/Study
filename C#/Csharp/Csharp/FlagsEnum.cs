using System;
class FlagsEnum
{
    //[Flags]를 통해 enum타입이 비트 필드(1,2,4,8..)를 갖고 있다는 것을 표시
    [Flags]    
    enum Border
    {
        None = 0,
        Top =  1,
        Right = 2,
        Bottom = 4,
        Left = 8
    }

    static void main(string[] args)
    {
        //or연산자로 여러개의 플래그를 가질 수 있다.
        Border b = Border.Top | Border.Bottom;

        //&연산자로 플래그 체크
        //&연산자(비트 연산자) : a & b 일 때 a,b 둘 다 1인 경우에 1이 됨
        if ((b & Border.Top) != 0)
        {
            //HasFlag()로 플래그 체크
            if (b.HasFlag(Border.Bottom))
            {
                //Top,Bottom
                Console.WriteLine(b.ToString());
            }
        }
    }
}
