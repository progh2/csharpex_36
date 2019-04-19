using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assign하는 값을 바탕으로 추정하여 타입이 정의되는 키워드. 
            // 지역 변수로만 사용 가능하며 메서드 안에서만 키워드로 취급당하는 대표적인 Context Keyword이다.
            // 컴파일 시점에 타입을 추정하여 해당 Data Type으로 바꿔치기 된다.
            var number = 100;
            // number = "100"; 

            // 각 Data Type 별 GetType()메소드 출력 시 타입이 어떻게 출력되는지 기억한다.
            var lotto = 10000000000L;
            var str = "안녕하세요";
            var this_double = 3.141592;
            var this_float = 3.14F;
            var this_bool = true;
            var this_char = 'H';

            Console.WriteLine("number: " + number.GetType());
            Console.WriteLine("lotto: " + lotto.GetType());
            Console.WriteLine("str: " + str.GetType());
            Console.WriteLine("this_double: " + this_double.GetType());
            Console.WriteLine("this_float: " + this_float.GetType());
            Console.WriteLine("this_bool: " + this_bool.GetType());
            Console.WriteLine("this_char: " + this_char.GetType());

            // 각 자로형 별 최대, 최소 값 출력.
            // int형가 long형은 최댓값과 최솟값의 마지막 숫자가 다름의 주의한다.
            // float과 double은 최댓값, 최솟값의 숫자가 기호만 빼고 같다.

            Console.WriteLine("int형 최대" + int.MaxValue);
            Console.WriteLine("int형 최소" + int.MinValue);
            Console.WriteLine("long형 최대" + long.MaxValue);
            Console.WriteLine("long형 최소" + long.MinValue);
            Console.WriteLine("float형 최대" + float.MaxValue);
            Console.WriteLine("float형 최소" + float.MinValue);
            Console.WriteLine("double형 최대" + double.MaxValue);
            Console.WriteLine("double형 최소" + double.MinValue);
            Console.WriteLine("char형 최대" + char.MaxValue);
            Console.WriteLine("char형 최소" + char.MinValue);

            // Literal 리터럴 
            // 리터럴은 기본적으로 정수형은 int형, 실수는 double형으로 취급된다.
            // float이나 long형으로 취급하고 싶다면 F나 L을 리터럴 수에 붙여서 알려줘야 한다.
            int i_int = 100;
            long i_lng = 100L;
            double i_dbl = 100.0;
            float i_flt = 100.0F;
            char i_chr = 'A';

            // 자료형의 표현 크기 (암묵적 형변환 가능) Type Casting
            // Data Type의 크기와 Data Type이 표현 가능한 수의 범위는 다르다. 
            // float은 4바이트, long은 8바이트임에도 표현 가능한 수의 범위가 커서 long을 float에 넣을 수 있다.
            i_dbl = i_flt = i_lng = i_int = i_chr;

            // string -> 해당타입 변환은 해당 타입에 맞는 올바른 문자열을 넣어주어야만 변환이 된다.
            // 적절한 내용을 넣지 않으면 System.FormatException이 발생한다.
            // 가장 큰 예외는 System.Exception 으로 처리할 수 있다.
            // try, catch 사용법은 자바와 동일하다.
            string strInt = "50";
            string strLong = "20000000000"; // 200억. 
            string strDouble = "50.0";
            string strFloat = "50.0";
            string strString = "ABCDE";

            try
            {
                Console.WriteLine(int.Parse(strInt));
                Console.WriteLine(long.Parse(strLong));
                Console.WriteLine(double.Parse(strDouble));
                Console.WriteLine(float.Parse(strFloat));
                Console.WriteLine(int.Parse(strString)); // 형식 예외 발생함
            }
            catch (System.FormatException e)
            {
                Console.WriteLine("형식 예외 발생!");
                Console.WriteLine(e.Message);
            }
            catch(System.Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // Data Type은 bool이고 저장되는 값은 true 또는 false이다. (소문자에 주의)
            // 이를 출력하면 True 또는 False로 출력된다.
            bool trueOrFalse = true;
            Console.WriteLine(trueOrFalse.ToString());

            // 문자열로 간편하게 변경하려면 "" + 변수 와 같이 사용하면 된다. 
            int a = 1999;
            Console.WriteLine("" + a);

            // character형과 string 조합도 잘 출력된다.
            char c = 'a';
            string c2 = "" + c;
            Console.WriteLine(c2);

            // 추가된 부분! 
            // 정수형(int, long) 자료형은 2의 배수의 수만큼 표현할 수가 있는데, 0이 있기 때문에
            // 양수와 음수 중 하나가 숫자가 작아질 수 밖에 없다. 그래서 음수가 양수보다 수가 하나 더 많다.
            // int형의 경우 최댓값 2147483647, 최솟값 -2147483648 로 음수가 하나 더 많다.
            // 이렇기에 최솟값에 -1을 곱할 경우 int형으로 표현할 수가 없게되는 문제가 생긴다.
            // C#의 경우 이럴 경우 그냥 최솟값을 출력하도록 되어있다. 
            // 만약 제대로 2147483648이 출력되게 하고 싶다면 long과 같은 더 큰 자료형을 사용해야 한다.
            // 그러면 long의 경우는? float이나 double을 사용해서 표현이 가능할 것이다. 하지마 이 경우
            // float이나 double형 특성상 소숫점 특정 자리 수 이하 값이 왜곡되어 살짝 다른 값을 가지게 되는 문제가 있다.
            int minInt = int.MaxValue;
            Console.WriteLine( minInt );    
            Console.WriteLine(-minInt);
            minInt = int.MaxValue;
            Console.WriteLine(minInt);
            Console.WriteLine( - minInt );  // 주의: 양수에는 2147483648이 없어서 값이 변하지 않음
            Console.WriteLine(minInt * -1);  // 주의: 양수에는 2147483648이 없어서 값이 변하지 않음
            Console.WriteLine(minInt * -1L);  // long형으로 바꿔주면 해결(리터럴을 long형으로)
            Console.WriteLine((int)minInt * -1);  // long형으로 바꿔주면 해결(변수를 long으로)
            Console.WriteLine(-2147483648);  
            //Console.WriteLine(-(-2147483648)); // 직접 값을 명시하면 에러 발생,컴파일 안됨
            //Console.WriteLine(-1 * (-2147483648)); // 위와 동일
            Console.WriteLine(-1L * (-2147483648)); // long형으로 바꿔주면 해결(리터럴을 long형으로)
            Console.WriteLine((long) -1 * (-2147483648)); // long형으로 바꿔주면 해결(변수를 long으로)
                
            // long의 경우
            long minLong = long.MinValue;
            Console.WriteLine( minLong); // -9223372036854775808
            Console.WriteLine(-1 * minLong); // -1을 곱해도 값이 같다. long은 9223372036854775808 값을 표현할 수 없기 때문.
            Console.WriteLine(-1F * minLong); // float으로 한 경우. 9.223372E+18 로 소숫점 특정 자리수 이하 값이 왜곡되었다.
            Console.WriteLine(-1.0 * minLong); // double로 변경한 경우. 9.22337203685478E+18 로 좀 더 정밀해지긴 했지만 실제 값과는 다소 차이가 있다.
            
        }
    }
}
