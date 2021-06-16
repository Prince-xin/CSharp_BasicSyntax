using System;

namespace learn13_parse
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Parse()：
             *  字符转换
             *  eg：int.Parse("123")
             *  将"123"转化成整型，并将返回值赋值给number
             */

            //int number = int.Parse("12345");
            //Console.WriteLine(number);



            /*
             * TryParse()
             *  语法：
             *      数据类型.TryParse("待转换类型", out 数据类型)
             *   释义：将待转换的类型转成需要的数据类型，成功后返回True，不成功则返回False；
             *        将待转换的数据通过 out 的变量传出方法
             * 
             */
            
            int number = 0;
            bool b = int.TryParse("123456", out number);
            Console.WriteLine(b);
            Console.WriteLine(number);

            Console.ReadKey();


        }
    }
}
