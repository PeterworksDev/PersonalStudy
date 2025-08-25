// Study Module : https://learn.microsoft.com/ko-kr/training/modules/dotnet-debug/
using System.Diagnostics;


namespace MyStudy
{
    public class DotnetDebug
    {
        public int Fibonacci(int n)
        {

            Debug.WriteLine($"Entering {nameof(Fibonacci)} method");
            Debug.WriteLine($"We are looking for the {n}th Number");

            int n1 = 0;
            int n2 = 1;
            int sum;

            for (int i = 2; i < n; i++)
            {
                sum = n1 + n2;
                n1 = n2;
                n2 = sum;
                Debug.WriteLineIf(sum == 1, $"sum is 1, n1 is {n1}, n2 is {n2}");
            }

            Debug.Assert(n2 == 5, "The return Value is not 5 and it should be.");

            return n == 0 ? n1 : n2;  // 삼항연산자 n=0 이면 n1, 아니면 n2 를 리턴.
        }
    }
    // Your code here
}