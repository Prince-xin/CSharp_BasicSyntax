using System;

namespace learn05_convert
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 类型转换
             * 当数据类型步兼容时采用 Convert.To数据类型(待转换的值)；
             * 要求：数据的值形式上能转换得过去
             */

            Console.WriteLine("请输入您的姓名：");
            string strName = Console.ReadLine();
            Console.WriteLine("请输入语文成绩：");
            string strChinese = Console.ReadLine();
            Console.WriteLine("请输入数学成绩：");
            string strMath = Console.ReadLine();
            Console.WriteLine("请输入英语成绩：");
            string strEnglish = Console.ReadLine();

            double chinese = Convert.ToDouble(strChinese);
            double math = Convert.ToDouble(strMath);
            double english = Convert.ToDouble(strEnglish);

            Console.WriteLine("{0}同学你好，你的总分是{1}分，平局分是{2:0.00}分", strName, chinese + math + english, (chinese + math + english) / 3);


            Console.ReadKey();

        }
    }
}
