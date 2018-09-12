using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            int a, b, c;
            Console.Write("Please input an int");
            s = Console.ReadLine();
            a = Int32.Parse(s);
            Console.Write("Please another input an int");
            s = Console.ReadLine();
            b = Int32.Parse(s);
            c = a * b;
            Console.WriteLine("their product is "+c);
        
        }
    }
}
