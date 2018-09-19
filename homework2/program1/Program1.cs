using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    class Program1
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("please input an integer:");
            int n =Int32.Parse(System.Console.ReadLine());
            int i = 2;
            while( n >= i)
            {
                if(n % i == 0)//查找从小到大的素数因子
                {
                    System.Console.Write(i + " ");
                    n /= i;
                    while( n % i == 0)//如果该素数因子还能被除
                    {
                        n /= i;
                    }
                }
                else
                {
                    i++;
                }          
            }

        }
    }
}
