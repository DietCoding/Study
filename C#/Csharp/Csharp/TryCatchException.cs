using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class TryCatchException
{
    static void Main(string[] args)
    {
        try
        {
            //실행 문장
        }
        catch(IndexOutOfRangeException ex)//배열 관련 예외 처리
        {
            //catch문에서 exception을 다시 상위 호출자로 보내고 싶을 때
            throw new IndexOutOfRangeException("Invalid index", ex);
            //새 객체의 매개변수로 이전 exception 정보를 저장 
        }
        catch(FileNotFoundException ex)
        {
            throw ex;
            //일반적으로 사용하지 않는 것이 좋다.
        }
        catch(Exception ex)
        {
            throw;
            //catch문에서 잡힌 exception 전달
        }
        finally
        {
            //exception 발생 여부와 상관없이 마지막에 반드시 실행
            Console.WriteLine("나니모 나캇다!");
        }
    }
}

