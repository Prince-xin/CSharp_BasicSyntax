using System;

namespace learn17_struct
{
    //定义结构体
    public struct Person
    {
        public string _name;
        public Gender _gender;
        public short _age;
    }

    //定义枚举类型
    public enum Gender
    {
        man,
        woman
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 结构体（struct）
             *  语法：
             *      public struct 结构体名
             *      {
             *          成员  //字段
             *      }
             *      
             *  声明结构体变量：结构体名 变量名；
             *  给结构体变量的成员赋值：变量名.成员 = 值;
             *  
             * ★字段：定义规范，需在字段名前加下划线（_)
             * 
             * ★一般在命名空间下定义结构体
             * 
             * ★在定义成员字段时，加上public
             */

            Person zhangsan;
            zhangsan._name = "张三";
            zhangsan._gender = Gender.man;
            zhangsan._age = 18;

            Person lisi;
            lisi._name = "李四";
            lisi._gender = Gender.woman;
            lisi._age = 108;

            Console.WriteLine("我叫{0}，性别：{1}，今年{2}岁了", zhangsan._name, zhangsan._gender, zhangsan._age);
            Console.WriteLine("我叫{0}，性别：{1}，今年{2}岁了", lisi._name, lisi._gender, lisi._age);

            Console.ReadKey();
        }
    }
}
