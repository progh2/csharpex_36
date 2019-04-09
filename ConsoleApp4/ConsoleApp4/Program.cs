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
            var number = 100;
            // number = "100"; x

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
            int i_int = 100;
            long i_lng = 100L;
            double i_dbl = 100.0;
            float i_flt = 100.0F;
            char i_chr = 'A';

            // 자료형의 표현 크기 (암묵적 형변환 가능) Type Casting
            i_dbl = i_flt = i_lng = i_int = i_chr;

            string strInt = "50";
            string strLong = "20,000,000,000"; // 200억
            string strDouble = "50.0";
            string strFloat = "50.0";
            string strString = "ABCDE";

            try
            {
                Console.WriteLine(double.Parse(strInt));
                Console.WriteLine(double.Parse(strLong));
                Console.WriteLine(double.Parse(strDouble));
                Console.WriteLine(double.Parse(strFloat));
                Console.WriteLine(double.Parse(strString));
            }
            catch (System.FormatException e)
            {
                Console.WriteLine("형식 에러 발생!");
                Console.WriteLine(e.Message);
            }
            catch(System.Exception e)
            {
                Console.WriteLine(e.Message);
            }

            bool trueOrFalse = true;
            trueOrFalse.ToString();

            int a = 1999;
            Console.WriteLine("" + a);

            char c = 'a';
            string c2 = "" + 'a';
            Console.WriteLine(c2);

        }
    }
}
