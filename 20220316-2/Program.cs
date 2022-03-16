using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220316_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double R=9999;
            double num1, num2;
            string op;
            Console.WriteLine("請輸入第一個數");
            num1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("請輸入第二個數");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("請輸入運算子");
            op = Console.ReadLine();
            switch (op)
            {
                case"+":
                    Console.WriteLine("{0}",num1+num2);
                    break;
                case "-":
                    Console.WriteLine("{0}", num1 - num2);
                    break;
                case "*":
                    Console.WriteLine("{0}", num1 *num2);
                    break;
                case "/":
                    Console.WriteLine("{0}", num1 / num2);
                    break;
                default:
                    Console.WriteLine("無效運算");
                    break;

            }
            Console.WriteLine("計算算結果為{0}",R);
            Console.Read();
        }
    }
}
