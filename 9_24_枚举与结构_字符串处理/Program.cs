using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_24_枚举与结构_字符串处理
{
    public struct Point //结构：平面坐标
    {
        public int x, y;
        public static int z = 1;//静态字段可以有变量初始化设定项
        public Point(int x,int y)
        {
            this.x = x;this.y = y;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();//调用默认的构造函数
            Console.WriteLine("平面坐标 1:x={0},y={1}",p1.x,p1.y);
            Point p2 = new Point(10,10);//调用2个参数的构造函数
            Console.WriteLine("平面坐标 2:x={0},y={1}", p2.x, p2.y);
            Point p3;
            //Console.WriteLine("平面坐标 3:x={0},y={1}", p3.x, p3.y);//编译错误
            p3.x = 22;p3.y = 33;
            Console.WriteLine("平面坐标 3:x={0},y={1}", p3.x, p3.y);//编译错误

        }
    }
}
