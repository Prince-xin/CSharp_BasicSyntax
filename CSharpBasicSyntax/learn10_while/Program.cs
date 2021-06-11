using System;

namespace learn10_while
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * while 循环
             *  语法：
             *      while(循环条件)
             *      {
             *          循环体;
             *      }
             *      
             *  释义: ①当while的循环条件满足时，进入循环体执行其中的代码，直到while不满足是退出循环。
             *       ②当while的循环条件不满足时，则不进入循环。
             * 
             * break
             *  作用：结束当前循环。
             *  
             *  
             */

            #region 小练习
            //int i = 0;
            //while ( i < 10)
            //{
            //    Console.WriteLine("第{0}遍：花里胡哨！", i+1);
            //    i++;
            //}

            // 计算1~100的和
            //int i = 1;
            //int sum = 0;
            //while (i <=100 )
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine("sum = {0}", sum);

            // 计算1~100的偶数和
            //int i = 0;
            //int sum = 0;
            //while(i <= 100)
            //{
            //    if (i % 2 == 0)
            //    {
            //        sum += i;
            //    }
            //    i++;
            //}
            //Console.WriteLine("sum = {0}", sum);
            #endregion

            // 实现账号登陆：user = admin，password = 123456789
            // 如果账号或密码错误则重新输入
            #region code
            //string user = "";
            //string password = "";

            //while (user != "admin" || password != "123456789")
            //{
            //    Console.Clear();
            //    Console.WriteLine("请输入用户名：");
            //    user = Console.ReadLine();
            //    Console.WriteLine("请输入密码：");
            //    password = Console.ReadLine();
            //}

            //if (user == "admin" && password == "123456789")
            //{
            //    Console.WriteLine("用户名与密码正确，身份验证成功！正在进行登陆……");
            //}
            #endregion

            // 输入班级人数，然后依次输入成绩，计算学员的平均成绩跟总成绩
            #region code
            Console.WriteLine("请输入你们班级人数：");
            try
            {
                int classNumber = Convert.ToInt32(Console.ReadLine());
                double score = 0;
                double sum = 0;
                int i = 0;
                while (i < classNumber)
                {
                    Console.WriteLine("请输入第{0}位同学的成绩：", i + 1);
                    score = Convert.ToDouble(Console.ReadLine());
                    sum += score;
                    i++;
                }
                Console.WriteLine("该班级总人数为{0}，总成绩为{1}分，平均分为{2}", classNumber, sum, sum / classNumber);
            }
            catch
            {
                Console.WriteLine("您输入的字符无法转换为数字，程序结束！");
            }
            #endregion



            Console.ReadKey();

        }
    }
}
