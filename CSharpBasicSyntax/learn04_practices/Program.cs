using System;

namespace learn04_practices
{
    class Program
    {
        static void Main(string[] args)
        {
            //计算46天是几周几天
            //int days = 46;
            //int week = 46 / 7;
            //int day = 46 % 7;
            //Console.WriteLine("{0}天是{1}周{2}天", days, week, day);

            //计算107653秒是几天几小时几分钟几秒
            int seconds = 107653;
            int day = seconds / (60 * 60 * 24);
            int house = seconds % (60 * 60 * 24) / (60 * 60);
            int mins = seconds % (60 * 60 * 24) % (60 * 60) / 60;
            int secs = seconds % (60 * 60 * 24) % (60 * 60) % 60;
            Console.WriteLine("{0}秒是{1}天{2}时{3}分钟{4}秒", seconds, day, house, mins, secs);


            Console.ReadKey();

        }
    }
}
