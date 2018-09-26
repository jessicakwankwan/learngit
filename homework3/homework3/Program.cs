using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace homework3
{
    //抽象类
    interface Shape
    {
        double GetS();
    }
    //具体类:三角形
    class Triangle : Shape
    {
        double s;
        private double s1;
        private double s2;
        private double s3;
        public Triangle(double s1, double s2, double s3)
        {
            this.s1 = s1;
            this.s2 = s2;
            this.s3 = s3;
        }
        public double GetS()
        {
            //判断是否能够组成三角形
            if ((s1 + s2 < s3) && (s1 + s3 < s2) && (s2 + s3 < s1) &&(Math.Abs(s1 - s2) < s3) && (Math.Abs(s1 - s3) < s2) && (Math.Abs(s2 - s3) < s1))
            {
                Console.WriteLine("这三条边无法组成一个三角形");
                s = 0;
            }
            else
            {
                double p = (s1 + s2 + s3) / 2;
                s = Math.Sqrt(p * (p - s1) * (p - s2) * (p - s3));
            }
            return s;
        }
    }
    //具体类：圆
    class Circle : Shape
    {
        double s;
        private double s1;

        public Circle(double s1)
        {
            this.s1 = s1;
        }
        public double GetS()
        {
            s = s1 * s1 * System.Math.PI;
            return s;
        }

    }
    //具体类：正方形
    class Square : Shape
    {
        double s;
        private double s1;

        public Square(double s1)
        {
            this.s1 = s1;
        }
        public double GetS()
        {
            s = s1 * s1;
            return s;
        }
    }
    //具体类：长方形
    class Rectangle : Shape
    {
        double s;
        private double s1;
        private double s2;

        public Rectangle(double s1, double s2)
        {
            this.s1 = s1;
            this.s2 = s2;
        }
        public double GetS()
        {
            s = s1 * s2;
            return s;
        }
    }
    //工厂类
    class Factory
    {
        //重载
        public static Shape getShape(string type, double s1)
        {
            Shape shape = null;
            if(type == "circle")
            {
                shape = new Circle(s1);
            }
            else if(type == "square")
            {
                shape = new Square(s1);
            }
            return shape;
        }
        public static Shape getShape(string type, double s1, double s2)
        {
            Shape shape = null;
            shape = new Rectangle(s1, s2);
            return shape;
        }
        public static Shape getShape(string type, double s1, double s2, double s3)
        {
            Shape shape = null;
            shape = new Triangle(s1, s2, s3);
            return shape;
        }

        internal static Shape getShape(double s1, double s2)
        {
            throw new NotImplementedException();
        }
    }
    //客户端
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape = null;
            System.Console.Write("请输入所求图形的类型:circle square triangle rectangle:  ");
            string type = System.Console.ReadLine();
            System.Console.WriteLine("请输入各边/半径");
            if (type == "circle" || type == "square")
            {
                double s1 = Convert.ToDouble(System.Console.ReadLine());
                shape = Factory.getShape(type, s1);
            }
            else if(type == "rectangle")
            {
                double s1 = Convert.ToDouble(System.Console.ReadLine());
                double s2 = Convert.ToDouble(System.Console.ReadLine());
                shape = Factory.getShape(type, s1, s2);
            }
            else if (type == "triangle")
            {
                double s1 = Convert.ToDouble(System.Console.ReadLine());
                double s2 = Convert.ToDouble(System.Console.ReadLine());
                double s3 = Convert.ToDouble(System.Console.ReadLine());
                shape = Factory.getShape(type, s1, s2, s3);
            }
            System.Console.WriteLine("该图形的面积为：" + shape.GetS());  
        }
    }
}