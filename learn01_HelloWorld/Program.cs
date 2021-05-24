using System;

namespace learn01_HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 注释符
            /*
             * a.注销
             * b.解释
             */

            // 单行注释

            /*
             * 多行注释
             */

            /// 文档注释，一般用于解释类或方法
            #endregion

            // 每行代码的结束都以分号（;）结尾
            
            Console.WriteLine("Hello World!");  // 在控制台输出双引号的内容
            Console.ReadKey();  // 暂停当前的程序，待用户按下任意键后程序继续运行并将用户按下的内容输出到控制台

        }
    }
}
