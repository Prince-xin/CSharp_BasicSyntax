using System;

namespace learn09_switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * switch-case  选择分支结构
             * 语法:
             *      switch(变量或表达式的值)
             *      {
             *          case 值1：待执行代码块;break;
             *          case 值2：待执行代码块;break;
             *          …………
             *          defaul：待执行代码块;break;
             *      }
             * 其中case的值应与switch的值类型一致，否则报错;
             */

            // 练习一：五级计分制
            #region code
            //Console.WriteLine("请输入您的成绩：");
            //int score = 0;
            //try
            //{
            //    score = Convert.ToInt32(Console.ReadLine());
            //    switch (score / 10)
            //    {
            //        case 10:
            //        case 9: Console.WriteLine("您的成绩属于A级"); break;
            //        case 8: Console.WriteLine("您的成绩属于B级"); break;
            //        case 7: Console.WriteLine("您的成绩属于C级"); break;
            //        case 6: Console.WriteLine("您的成绩属于D级"); break;
            //        case 5:
            //        case 4:
            //        case 3:
            //        case 2:
            //        case 1:
            //        case 0: Console.WriteLine("您的成绩属于E级"); break;
            //        default:
            //            Console.WriteLine("你个龟孙，你输入的玩意有误，老子不给你评级了！");
            //            break;
            //    }
            //}
            //catch
            //{
            //    Console.WriteLine("您输入的字符无法转成数字！！！");
            //}

            #endregion

            /* 
             * 练习二：李华今年的工资是5000，请老总给他评级确定明年薪资的
             *      A级：加1000薪
             *      B级：加500薪
             *      C级：不加不减
             *      D级：降薪500
             */
            #region code
            int saraly = 5000;
            Console.WriteLine("请老板评级：");
            string lever = Console.ReadLine();
            bool flas = true;
            switch (lever)
            {
                case "A": saraly += 1000; break;
                case "B": saraly += 500; break;
                case "C": Console.WriteLine("龟儿子，再接再厉");break;
                case "D": saraly -= 500; break;
                default:
                    Console.WriteLine("老板输入有误，无法正确评级！");
                    flas = false;
                    break;
            }
            if (flas)
            {
                Console.WriteLine("明年李华的工资为：{0}", saraly);
            }
            #endregion
            Console.ReadKey();
            

        }
    }
}
