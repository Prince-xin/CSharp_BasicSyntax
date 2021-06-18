using System;

namespace learn16_enum
{

    //定义一个枚举变量
    public enum Gender
    {
        man,
        woman
    }

    //
    public enum Season
    {
        春 = 1,
        夏,
        秋,
        冬,
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * public：访问修饰符。公共的，都可以访问和使用。
             * enum：关键字。声明枚举的关键字。
             * 枚举名：符合Pascal命名规范。
             * 
             * 语法：
             *  定义：
                 * [public] enum 枚举名
                 * {
                 *      值1，
                 *      值2
                 *      ……
                 * }
             *  声明：枚举名 变量名；
             *  赋值：变量名 = 枚举名.值X;
             * 
             */

            // 声明并赋值
            Gender gender = Gender.man;
            int intGen1 = (int)gender;
            string strGen = gender.ToString();
            string str01 = "1", str02 = "man";
            Gender gender02 = (Gender)Enum.Parse(typeof(Gender), str01);
            Gender gender03 = (Gender)Enum.Parse(typeof(Gender), str02);

            Console.WriteLine("正常输出：gender--->{0}", gender);
            Console.Write("枚举类型转整型：Convert.ToInt32(gender)--->{0}\t", Convert.ToInt32(gender));
            Console.WriteLine("枚举类型转整型：intGen--->{0}", intGen1);
            Console.WriteLine("枚举类型转字符串：strGen--->{0}", strGen);
            Console.Write("字符串转枚举类型：gender02--->{0}\t", gender02);
            Console.WriteLine("gender03--->{0}", gender03);


            //小练习：接受用户输入的值，输出相应的季节
            #region code
            Console.WriteLine("请输入季节编号：1->春\t2->夏\t3->秋\t4->冬");
            string input = Console.ReadLine();
            bool falg = true;
            Season season = Season.春;
            switch (input)
            {
                case "1":
                    season = (Season)Enum.Parse(typeof(Season), input);break;
                case "2":
                    season = (Season)Enum.Parse(typeof(Season), input);break;
                case "3":
                    season = (Season)Enum.Parse(typeof(Season), input);break;
                case "4":
                    season = (Season)Enum.Parse(typeof(Season), input);break;
                default:
                    Console.WriteLine("输入有误，无法判断！");
                    falg = false;
                    break;
            }
            if (falg)
            {
                Console.WriteLine("当前的季节为：{0}", season);
            }
            #endregion


            /*
             * ★枚举类型里面的值默认从 0 开始计数。也可以手动修改计数，eg:值1=10，
             * 
             * ★枚举类型转整型：枚举的值对应的计数就是转换后的结果
             * 
             * ★整型转枚举类型：如果数字在枚举类型的计数中出现，则输出对应的值；如果没有则将原来的整型输出。
             * 
             * ★枚举类型转字符串：调用ToString()方法直接转换为字符串类型。
             * 
             * ★字符串转枚举类型：(带转换的枚举名)Enum.Parse(typeof(待转换的枚举名), 待转换的值字符串)
             */

            Console.ReadKey();


        }
    }
}
