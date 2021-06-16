using System;

namespace learn14_sanyuanBDS
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 三元表达式
             *  语法：
             *      表达式 ? 值1 : 值2;
             *  释义：表达式：结果只能为bool类型（True/False）
             *       值1 与 值2 的类型要一致，且与最后被赋值的变量表达式一致
             *     当表达式为True时，结果返回 值1；
             *     当表达式为False时，结果返回 值2；
             */

            int num01 = 100;
            int num02 = 200;
            int max = num01 > num02 ? num01 : num02;
            Console.WriteLine(max);


            /*
             * Random
             * 产生随机数
             *      创建对象：Random 变量名 = new Random();
             *      调用方法：int number = 变量名.Next(1,11); //随机数产生区间1~10，左闭右开
             */
            Random r = new Random();
            for (int i = 0; i < 5; i++)
            {
                int number = r.Next(1, 10);
                Console.WriteLine(number);
            }
            

            Console.ReadKey();


        }
    }
}
