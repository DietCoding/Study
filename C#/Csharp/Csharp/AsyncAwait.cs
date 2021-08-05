using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class AsyncAwait
{
    //async의 리턴타입은 Task<Tresult>(리턴값o) Task(리턴값x)
    //await은 Task가 끝날때까지 기다렸다가 완료후 다음 실행문부터 실행한다

    static void Main(string[] args)
    {
        AsyncAwait a = new AsyncAwait();
        Console.WriteLine("Main:" + Thread.CurrentThread.ManagedThreadId);
        a.Run();
        Console.ReadLine();
    }
    private async void Run()
    {
        //비동기로 도는 task1
        var task1 = Task.Run(() => LongCalcAsync(10));
        Console.WriteLine(SynchronizationContext.Current);
        //task1 끝나면 결과치를 sum에 할당 
        int sum = await task1;
        //Worker Thread에서 실행
        Console.WriteLine(sum);
        Console.WriteLine(Thread.CurrentThread.ManagedThreadId);

    }
    private int LongCalcAsync(int times)
    {
        int result = 0;
        for(int i = 0; i < times; i ++)
        {
            result += i;
            Thread.Sleep(1000);
        }
        return result;
    }
}




