using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program3
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 99;
            int[] array = new int[length];
            for(int i = 0; i<length; i++)
            {
                array[i] = i + 2;//数组首元素从2开始
            }
            int lengthafter = length;
            for (int basic = 2; basic <= 100; basic++)//先去除2的倍数、再去除3的倍数、4的倍数、、、
            {
                for (int i = 0, a = 0; i < length; i++)//遍历整个数组，a为新数组的下标
                {
                    if (array[i] ==basic || array[i] % basic != 0)//判断不是2、3、4、、、的倍数（不含本身）
                    {
                        array[a] = array[i];//保留该数
                        a += 1;//新数组下标+1
                    }
                    else
                    {
                        lengthafter -= 1;//若是，后来数组的长度减一，不赋给后来的数组
                    }
                }
                length = lengthafter;//新数组的长度改变
            }
            System.Console.Write("the prime numbers between 2 and 100 are:");
            for(int i = 0; i<lengthafter; i++)
            {
                System.Console.Write(array[i] + "\n");
            }
        }
    }
}
