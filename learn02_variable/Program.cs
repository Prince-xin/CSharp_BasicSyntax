using System;

namespace learn02_variable
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 变量
            /*
             * 释义：用来在计算机当中存储数据
             * 1、确定数据类型 
             *      数值类型：int 整型             short  短整型
             *               float 单精度浮点型    double  双精度浮点型
             *               bool   布尔类型       char 字符型
             *               string 字符串型       decimal  [一般用于金钱]
             *               ……
             * 2、变量名要有意义，即“见名知意”
             *      规则： a、以“字母”、“_”或“@”符号开头
             *            b、后面可以跟任意“字母”、“_”或“数字”
             *            c、不能与C#的关键字重复
             *            d、区分大小写
             *      规范： 1、Camel：组合单词时，首单词首字母小写，其余单词首字母大写。多用于变量命名
             *             2、Pascal：组合单词时，所有单词的首字母都要大写。一般用于类或方法命名
             *             
             * 形式：1、数据类型 变量名；
             *          变量名 = 值；
             *          
             *       2、数据类型 变量名 = 值；
             */
            #endregion

            #region 赋值运算符
            /*
             * 释义：将等号右边的值赋值等号左边的变量
             * 
             * 形如：int a = 13;
             * 
             */
            #endregion

            //int number;
            //number = 100;

            //short age;
            //char grander;
            //string str = "花里胡哨";

            #region 占位符
            /*
             * 释义：先挖坑再填坑
             * eg：Console.WriteLine("我是{0},今年已经{1}岁了", name, age);
             */
            #endregion
            //string name = "守望星";
            //short age = 18;
            //Console.WriteLine("我是{0},今年已经{1}岁了", name, age);

            #region 交换两个变量的值
            int n1 = 3, n2 = 2;
            // 方法一：声明第三方变量
            //int temp;
            //temp = n1;
            //n1 = n2;
            //n2 = temp;
            //Console.WriteLine("n1 = {0}, n2 = {1}", n1, n2);
            // 方法二：利用加减法
            //n1 = n1 + n2;
            //n2 = n1 - n2;
            //n1 = n1 - n2;
            //Console.WriteLine("n1 = {0}, n2 = {1}", n1, n2);
            #endregion



        }
    }
}
