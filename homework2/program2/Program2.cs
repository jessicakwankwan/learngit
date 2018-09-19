using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace promgram2
{
    class Program2
    {
        static void Main(string[] args)
        {
            int[] array;//创建一个数组
            System.Console.WriteLine("please input the length of the array");
            int length = Int32.Parse(System.Console.ReadLine());
            array = new int[length];
            for(int i = 0; i < length; i++)
            {
                System.Console.WriteLine("please input the {0}th number of the array", i);
                array[i] = Int32.Parse(System.Console.ReadLine());
            }
            int a = array[0], b = array[0];
            for (int i = 0; i<length - 1; i++)//求数组的最大值、最小值
            {
                a = a > array[i + 1] ? a : array[i + 1];
                b = b < array[i + 1] ? b : array[i + 1];
            }
            System.Console.WriteLine("the max number of the array is :" + a);
            System.Console.WriteLine("the min number of the array is :" + b);
            int sum = 0;
            for(int i = 0; i < length; i++)//求数组的和、平均值
            {
                sum += array[i];
            }
            double averrage = Convert.ToDouble(sum) / Convert.ToDouble(length);
            System.Console.WriteLine("the sum of the array is :" + sum);
            System.Console.WriteLine("the averrage of the array is :" + averrage);

        }
    }
}
