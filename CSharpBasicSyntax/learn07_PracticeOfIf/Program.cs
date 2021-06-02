using System;

namespace learn07_PracticeOfIf
{
    class Program
    {
        static void Main(string[] args)
        {
            // 输入三个数判断最大值
            #region code
            //Console.WriteLine("请分别输入三个数值：");
            //int number01 = Convert.ToInt32(Console.ReadLine());
            //int number02 = Convert.ToInt32(Console.ReadLine());
            //int number03 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("第一个数是：{0}\t第二个数是：{1}\t第三个数是：{2}", number01, number02, number03);
            //if(number01 > number02)
            //{
            //    if (number01 >number03)
            //    {
            //        Console.WriteLine("其中最大值是{0}", number01);
            //    }
            //    else
            //    {
            //        Console.WriteLine("其中最大值是{0}", number03);
            //    }
            //}
            //else
            //{
            //    if (number02 > number03)
            //    {
            //        Console.WriteLine("其中最大值是{0}", number02);
            //    }
            //    else
            //    {
            //        Console.WriteLine("其中最大值是{0}", number03);
            //    }
            //}
            #endregion


            /*
             * 五级评分制
             * 1、90 <= score < 100   为A
             * 2、80 <= score < 90    为B
             * 3、70 <= score < 80    为C
             * 4、60 <= score < 70    为D
             * 5、score < 60         为E
             */
            #region code
            Console.WriteLine("请输入您的成绩，让我看看你在哪个层级：");
            int score = Convert.ToInt32(Console.ReadLine());
            if (90 <= score && score <= 100)
            {
                Console.WriteLine("好家伙，你的分数在 A级 层次");
            }
            else if (80 <= score && score <= 90)
            {
                Console.WriteLine("还行，你的分数在 B级 层次");
            }
            else if (70 <= score && score <= 80)
            {
                Console.WriteLine("高不成低不就，你的分数在 C级 层次");
            }
            else if (60 <= score && score <= 70)
            {
                Console.WriteLine("勉强及格的玩意，你的分数在 D级 层次");
            }
            else if (score < 60 && score >=0)
            {
                Console.WriteLine("辣鸡玩意，你不及格属于 E级 层次");
            }
            else
            {
                Console.WriteLine("成绩有误，无法判断！");
            }
            #endregion

            Console.ReadKey();
        }
    }
}
