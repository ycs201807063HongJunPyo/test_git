using System;

namespace project_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //문자열 서식 맞추기
            //Console.WriteLine은 기본적으로 문자열을 출력하는 메서드이므로
            //숫자를 출력할 때는 문자열로 변환하는 과정이 필요하다.
            //C#은 문자열 서식화에 사용할 수 있는 간단한 방법 두 가지를 제공한다.
            //1) string 형식의 Format() 메서드
            //2) 문자열 보간
            /*
            Console.WriteLine("{0}, {1}", 123, "최강컴소공");
            // string 형식의 Format() 메서드
            Console.WriteLine("Total : {0, 7:D}", 255); // 첨자 : 0, 맞춤(오른쪽 정렬) : 7칸의 공간 마련, 서식문자열(D : 10진수)
            Console.WriteLine("Total : {0, -7:D}", 255); // 첨자 : 0, 맞춤(왼쪽 정렬) : 7칸의 공간 마련, 서식문자열(D : 10진수)
            Console.WriteLine("Total : {0, 10:D}", 255); // 첨자 : 0, 맞춤(오른쪽 정렬) : 10칸의 공간 마련, 서식문자열(D : 10진수)
            Console.WriteLine("Total : {0, -10:D}", 255); // 첨자 : 0, 맞춤(왼쪽 정렬) : 10칸의 공간 마련, 서식문자열(D : 10진수)
            Console.WriteLine();
            // 문자열 보간
            Console.WriteLine($"Total : {255, -10:D}");
            Console.WriteLine($"{123}, {"최강컴소공"}");
            

            Console.WriteLine("{0:N0}", 123456789);  // N : 1000자리마다 , 로 구분하여표시 & 소수점 2자리까지 표시 || N0 : N에서 소수점 2자리를 표시하지 않음
            Console.WriteLine("{0:F}", 123.45); // F : 고정소수점 방식(정해진 숫자를 출력)
            
            //서식항목
            //{첨자, 맞춤 :서식문자열}

            string fmt = "{0, -20}{1, -15}{2, 30}";
            Console.WriteLine(fmt, "Publisher", "Author", "Title");
            Console.WriteLine(fmt, "Marvel", "Stan Lee", "Iron Man");
            Console.WriteLine(fmt, "Yuhan", "Hong Gildong", "C# Programming");
            Console.WriteLine(fmt, "Computer", "Yoo Sanseul", "C Programming Language");
            */

            int n = 123;
            string s = "최강컴소공";
            /// ★ string Foramt <-> 문자열 보간
            Console.WriteLine("{0}, {1}", 123, "최강컴소공");
            Console.WriteLine($"{123}, {"최강컴소공"}");
        }
    }
}
