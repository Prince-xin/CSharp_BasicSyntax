using System;

namespace learn03_symbol
{
    class Program
    {
        static void Main(string[] args)
        {
            // 接受用户输入的值
            //string str = Console.ReadLine();
            //Console.WriteLine(str);


            /*
             * 转义符
             * 释义：指\加一个特殊的字符，组成具有意义的字符
             * \n：换行
             * \"：英文半角双引号
             * \t：制表符
             * \b：退格。删除该符号的前一个字符
             * \r\n：在windows系统下有换行的作用
             * \\：表示一个'\'
             * ……
             */
            //string str1 = "今天天气好晴朗\n处处好风光";
            //string str2 = "今天天\b启\b好晴朗\t处处好风光";
            //Console.WriteLine(str1);
            //Console.WriteLine(str2);

            /* 
             * @ 符号
             * 1、取消‘\’在字符串中的转义作用
             * 2、保留原格式。按原格式输出
             */
            //string path = @"C:/user/23008/你猜.txt";

            /*
             * 算数运算符
             * +：两数相加
             * -：两数之差
             * *：两数成绩
             * /：除号的作用【两个整数相除结果为整数】
             * %：取余
             */

            /*
             * 类型转换
             *  隐式类型转换：
             *      要求：1、两种类型兼容
             *           2、目标类型大于原类型
             *  
             *  显式类型转换：
             *      要求：1、两种类型相兼容
             *           2、目标类型小于原来类型
             *      语法：(待转换的类型)要转换的值；
             */

            int number = 10;
            double num = number;

            int n1 = (int)num;

            Console.ReadKey();
        }
    }
}
