using System;

namespace learn06_if
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 关系运算符与逻辑运算符
            /*
             * 关系运算符
             * >：大于
             * <：小于
             * >=：大于等于
             * <=：小于等于
             * ==：等于
             * !=：不等于
             */

            /*
             * 逻辑运算符
             * &&：逻辑与。运算符两边同时为"True"，则结果才为"True"；反之为"False"。
             * ||：逻辑或。运算符满足任意一边为"True"，则结果才为"True"；反之为"False"。
             * ！：逻辑非。取反值。若表达式为"True"，则最终结果为"False"；反之为"True"。
             */

            /*
             * bool：布尔类型，只能存放两个值"True"或"False"。
             * 关系运算符与逻辑运算符的结果用布尔类型的变量存放
             */
            #endregion

            #region if相关语句的结构
            /*
             * if结构：
             * if(判断语句)
             * {
             *      待执行语句;
             * }
             * 释义：当if的判断语句为"True"时，则执行接下来的大括号内的代码。
             * 
             * if-else结构：
             * if(判断语句)
             * {
             *      待执行语句；
             * }
             * else
             * {
             *      待执行语句；
             * }
             * 释义：当if的判断语句为"True"时，则执行接下来的大括号内的代码。当结果为"False"时，则执行else里面的语句。
             * ☆：else 与其最近的 if 对应。
             * 
             * if-else if-else结构：
             * if(判断语句)
             * {
             *      待执行语句；
             * }
             * else if(判断语句)
             * {
             *      待执行语句；
             * }
             * …… ……
             * else if
             * …… ……
             * else
             * {
             *      待执行语句；
             * }
             * 释义：1、执行if里面的判断语句，若结果为"True"，则执行接下来大括号内的语句块
             *      2、当if里面的判断语句结果为"False"时，则执行接下来的else if里面的判断语句
             *      3、如果满足条件则进入else if其中大括号内执行其中的代码块
             *      4、如果都不满足则进入else内的大括号，执行其中的内容
             * 
             */
            #endregion

            //判断闰年
            //1、年份能够被400整除
            //2、年份能够被4整除，但不能被100整除
            Console.WriteLine("请输入需要判断的年份：");
            int year = Convert.ToInt32(Console.ReadLine());
            if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
            {
                Console.WriteLine("您输入的年份是闰年！！！");
            }
            else
            {
                Console.WriteLine("您输入的年份不是闰年！！！");
            }

            Console.ReadKey();
        }
    }
}
