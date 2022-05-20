using System;

namespace project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //문자열을 숫자로 변환
            Console.WriteLine(int.Parse("273"));
            Console.WriteLine(int.Parse("273").GetType());

            //숫자로 변환할 수 없는 문자열을 반환하는 경우 : 예외가 발생
            //Console.WriteLine(int.Parse("52.273"));
            Console.WriteLine(float.Parse("52.273"));   // 정상작동
            Console.WriteLine(int.Parse("ABC"));

            //기본 자료형을 문자열로 변환
            Console.WriteLine((52).ToString());
            Console.WriteLine((52).ToString().GetType());
            Console.WriteLine((52.273).ToString());
            Console.WriteLine(('A').ToString());
            ㄴ
            //소숫점 제거
            Console.WriteLine();
            double number = 52.273103;
            Console.WriteLine(number.ToString("0.0"));
            Console.WriteLine(number.ToString("0.00"));
            Console.WriteLine(number.ToString("0.000"));
            Console.WriteLine(number.ToString("0.0000"));
            */

            //숫자와 문자열 덧셈 : 숫자가 자동으로 문자열로 변환
            Console.WriteLine(52 + 273);    // 325
            Console.WriteLine("52" + 273);  // 52273
            Console.WriteLine("52" + "273");    // 52273
            Console.WriteLine(52 + 'A');    // 117


            //깃허브 테스트
            //깃허브 테스트//깃허브 테스트
            //깃허브 테스트//깃허브 테스트
            //깃허브 테스트//깃허브 테스트
            //깃허브 테스트//깃허브 테스트
        }
    }
}
