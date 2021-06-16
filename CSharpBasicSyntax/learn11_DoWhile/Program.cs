using System;

namespace learn11_DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * do-while 循环结构
             *  语法：
             *      do
             *      {
             *          循环体;
             *      }while(条件判断);
             *  结构释义：程序先进入循环体，执行完循环后进入while括号内进行判断。如果条件满足则再次进入
             *          循环，然后进行条件判断，如此反复循环；如果条件不满足则退出循环
             *  ☆程序必定执行至少一次循环体
             *  ☆while括号后面要跟英文半角分号
             */

            //模拟用户登陆，user = admin，password = 123456，
            //如果输入错误则重新输入
            #region code
            //string user = "";
            //string password = "";
            //do
            //{
            //    Console.Clear();
            //    Console.WriteLine("请输入用户名：");
            //    user = Console.ReadLine();
            //Console.WriteLine("请输入密码：");
            //    password = Console.ReadLine();
            //} while (user != "admin" || password != "123456");
            #endregion



            Console.ReadKey();


        }
    }
}
