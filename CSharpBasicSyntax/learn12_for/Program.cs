using System;

namespace learn12_for
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * for 循环
             *  语法：
             *      for(表达式①; 表达式②; 表达式③)
             *      {
             *          循环体④；
             *          
             *      }
             *  语法释义：①声明变量，变量初始化
             *           ②循环条件
             *           ④进入循环
             *           ③修改循环变量
             *   执行:    1 -> 2 -> 4 -> 3 -> 2 -> 4 -> 3 -> 2……
             */

            // 计算1~100之间的所有偶数和
            //int sum = 0;
            //for (int i = 0; i <= 100; i+=2)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);

            // 求100~999之间的水仙花数
            // 水仙花数：各位数之间的立方和等于该数
            int x, y, z;
            for (int i = 100; i <= 999; i++)
            {
                x = i / 100;
                y = i / 10 % 10;
                z = i % 10;
                if((x*x*x) + (y*y*y) + (z*z*z) == i)
                {
                    Console.WriteLine("{0}是水仙花数!", i);
                }
            }

            // 实现九九乘法表
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0} X {1} = {2}\t", j, i, i * j);
                }
                Console.WriteLine();
            }

            //小练习
            #region code
            Console.WriteLine("请输入一个整数：");
            try
            {
                int number = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < number; i++)
                {
                    Console.WriteLine("{0} + {1} = {2}", i, number - i, number);
                }
            }
            catch
            {
                Console.WriteLine("您输入的字符无法转换为数字!");
            }
            #endregion

            Console.ReadKey();

        }
    }
}
