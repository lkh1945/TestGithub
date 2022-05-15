using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //배열에서 3보다 큰 짝수를 찾는 함수 만들기
            // 가장 작은 짝수를 리턴한다.
            List<int> testList = new List<int>{ 1, 56, 2, 3, 4, 6 };
            int returnNumber = testList.Where(x => x > 3 && x % 2 == 0)
                .OrderBy(x => x)
                .First();
            Console.WriteLine(returnNumber);
            // && => and 조건 : true true 일 때 참
            // a && b : a, b랑 둘 다 참일 때 참 반환
            // || => or 조건 : 둘 중 하나라도 true이면 참 반환
        }
    }
}