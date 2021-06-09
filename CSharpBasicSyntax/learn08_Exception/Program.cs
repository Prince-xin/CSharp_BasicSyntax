using System;

namespace learn08_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 异常(Exceoption)
             * 释义：程序没有语法错误，但由于某些原因导致程序中止
             * 
             * 一般情况下，针对有可能出现异常的语句通过try-catch结构进行异常捕获
             * try - catch 语法结构：
             *      try
             *      {   
             *          肯能出现异常的语句块;
             *      }
             *      catch
             *      {
             *          如果出现异常的情况下需要执行的语句块;
             *      }
             */

            int number = 0;
            bool flas = true;
            Console.WriteLine("请输入正确的数字：");
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("您输入的不是数字，程序终止！");
                flas = false;
            }

            if (flas)
            {
                Console.WriteLine("结果为：{0}", number * 2);
            }
            
            Console.ReadKey();

        }
    }
}
