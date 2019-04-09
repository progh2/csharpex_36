using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 100;
            var str = "안녕하세요";
            var this_double = 3.141592;

            Console.WriteLine("number: " + number.GetType());
            Console.WriteLine("str: " + str.GetType());
            Console.WriteLine("this_double: " + this_double.GetType());

        }
    }
}
