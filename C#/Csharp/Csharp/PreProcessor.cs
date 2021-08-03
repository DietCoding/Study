#define oohyo

using System;

class PreProcessor
{
    //전처리기 지시어: 컴파일 시작전 컴파일러에 미리 처리하도록 지시
    //모든 C# 전처리기 지시어는 #으로 시작\
    //전처리기 지시어는 해당 파일 안에서만 효력 발생
    static void main(string[] args)
    {
#if (oohyo)
        Console.WriteLine("oohyo");
#else
        Console.writeLine("nono");
#endif
        //#define과 #if를 결합하여 조건별 코드 컴파일 가능
    }

    #region public int values
    public int age;
    public int money;
    #endregion

#pragma warning disable 3021
    //#pragma는 컴파일러 제작업체가 만든 지시어로 컴파일러마다 다름
    //위는 MS VS가 제공하는 경고메세지를 enable/disable하는 지시어
    //3021오류메시지를 disable한다.
}
